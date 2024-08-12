using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using scheduler.algo;
using scheduler;

namespace scheduler.algo
{
    internal class algorithm
    {
    }

    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RequiredRoomType { get; set; }
        public int TeacherId { get; set; }
        public List<int> StudentGroupIds { get; set; }
    }

    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<string> Features { get; set; }
    }

    public class Schedule
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int RoomId { get; set; }
        public int TeacherId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Group { get; set; }
    }

    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Tuple<DateTime, DateTime>> Availability { get; set; } // Using Tuple for simplicity
        public List<string> Specialisations { get; set; }
    }

    public class DatabaseContext
    {
        private readonly string _connectionString = "Data Source=SLINKYFOX;" +
                                                    "Initial Catalog=scheduler;" +
                                                    "User id=schedacc;" +
                                                    "Password=scheduleraccount;";

        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Class> GetClasses()
        {
            var classes = new List<Class>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM Classes", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var studentGroupIds = new List<int>(); // You'll need to parse this correctly from your DB schema
                                                                   // Assuming student_group_ids is stored as a comma-separated string
                            string[] groupIds = reader["student_group_ids"].ToString().Split(',');
                            foreach (var id in groupIds)
                            {
                                studentGroupIds.Add(int.Parse(id));
                            }

                            classes.Add(new Class
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Name = reader["name"].ToString(),
                                RequiredRoomType = reader["required_room_type"].ToString(),
                                TeacherId = Convert.ToInt32(reader["teacher_id"]),
                                StudentGroupIds = studentGroupIds
                            });
                        }
                    }
                }
            }
            return classes;
        }

        public List<Room> GetRooms()
        {
            var rooms = new List<Room>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM Rooms", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new Room
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Name = reader["name"].ToString(),
                                Type = reader["type"].ToString(),
                                Capacity = Convert.ToInt32(reader["capacity"]),
                                Features = new List<string>(reader["features"].ToString().Split(',')) // Assuming features are comma-separated
                            });
                        }
                    }
                }
            }
            return rooms;
        }

        public List<Teacher> GetTeachers()
        {
            var teachers = new List<Teacher>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM Teachers", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var availability = new List<Tuple<DateTime, DateTime>>();
                            // Assuming availability is stored as a semicolon-separated list of start-end times
                            string[] timeSlots = reader["availability"].ToString().Split(';');
                            foreach (var slot in timeSlots)
                            {
                                string[] times = slot.Split('-');
                                availability.Add(new Tuple<DateTime, DateTime>(
                                    DateTime.Parse(times[0]), DateTime.Parse(times[1])));
                            }

                            teachers.Add(new Teacher
                            {
                                Id = Convert.ToInt32(reader["teacher_id"]),
                                Name = reader["name"].ToString(),
                                Availability = availability,
                                Specialisations = new List<string>(reader["specialisation"].ToString().Split(','))
                            });
                        }
                    }
                }
            }
            return teachers;
        }

        public void SaveSchedule(Schedule schedule)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(
                    "INSERT INTO Schedules (ClassId, RoomId, TeacherId, StartTime, EndTime) VALUES (@ClassId, @RoomId, @TeacherId, @StartTime, @EndTime)", connection))
                {
                    command.Parameters.AddWithValue("@ClassId", schedule.ClassId);
                    command.Parameters.AddWithValue("@RoomId", schedule.RoomId);
                    command.Parameters.AddWithValue("@TeacherId", schedule.TeacherId);
                    command.Parameters.AddWithValue("@StartTime", schedule.StartTime);
                    command.Parameters.AddWithValue("@EndTime", schedule.EndTime);

                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public class ScheduleChromosome
    {
        public List<Schedule> ClassSchedules { get; set; }
        public double Fitness { get; set; }

        public ScheduleChromosome()
        {
            ClassSchedules = new List<Schedule>();
        }

        public void Randomize(List<Class> classes, List<Room> rooms, List<Teacher> teachers)
        {
            Random rand = new Random();

            foreach (var c in classes)
            {
                // Randomly assign room and teacher, and generate random time slots
                var availableRooms = new List<Room>();
                foreach (var r in rooms)
                {
                    if (r.Type == c.RequiredRoomType)
                        availableRooms.Add(r);
                }

                var availableTeachers = new List<Teacher>();
                foreach (var t in teachers)
                {
                    if (t.Id == c.TeacherId)
                        availableTeachers.Add(t);
                }

                if (availableRooms.Count > 0 && availableTeachers.Count > 0)
                {
                    var room = availableRooms[rand.Next(availableRooms.Count)];
                    var teacher = availableTeachers[rand.Next(availableTeachers.Count)];
                    var startTime = GenerateRandomStartTime(teacher.Availability);
                    var endTime = startTime.AddHours(1); // Assuming 1-hour class

                    ClassSchedules.Add(new Schedule
                    {
                        ClassId = c.Id,
                        RoomId = room.Id,
                        TeacherId = teacher.Id,
                        StartTime = startTime,
                        EndTime = endTime
                    });
                }
            }
        }

        private DateTime GenerateRandomStartTime(List<Tuple<DateTime, DateTime>> availability)
        {
            Random rand = new Random();
            var slot = availability[rand.Next(availability.Count)];
            int minutes = rand.Next((int)(slot.Item2 - slot.Item1).TotalMinutes);
            return slot.Item1.AddMinutes(minutes);
        }
    }

    public class FitnessCalculator
    {
        public double CalculateFitness(ScheduleChromosome chromosome, List<Room> rooms, List<Teacher> teachers)
        {
            double fitness = 0;

            // Room conflicts
            var roomUsage = new Dictionary<Tuple<int, DateTime>, int>();
            foreach (var schedule in chromosome.ClassSchedules)
            {
                var key = new Tuple<int, DateTime>(schedule.RoomId, schedule.StartTime);
                if (roomUsage.ContainsKey(key))
                    roomUsage[key]++;
                else
                    roomUsage[key] = 1;
            }

            foreach (var usage in roomUsage.Values)
            {
                if (usage > 1)
                {
                    fitness -= usage * 10;
                }
            }

            // Teacher conflicts
            var teacherUsage = new Dictionary<Tuple<int, DateTime>, int>();
            foreach (var schedule in chromosome.ClassSchedules)
            {
                var key = new Tuple<int, DateTime>(schedule.TeacherId, schedule.StartTime);
                if (teacherUsage.ContainsKey(key))
                    teacherUsage[key]++;
                else
                    teacherUsage[key] = 1;
            }

            foreach (var usage in teacherUsage.Values)
            {
                if (usage > 1)
                {
                    fitness -= usage * 10;
                }
            }

            return fitness;
        }
    }

    public class GeneticAlgorithm
    {
        private List<ScheduleChromosome> Population { get; set; }
        private int PopulationSize { get; set; }
        private int Generations { get; set; }
        private double MutationRate { get; set; }
        private FitnessCalculator FitnessCalculator { get; set; }

        public GeneticAlgorithm(int populationSize, int generations, double mutationRate)
        {
            PopulationSize = populationSize;
            Generations = generations;
            MutationRate = mutationRate;
            Population = new List<ScheduleChromosome>();
            FitnessCalculator = new FitnessCalculator();
        }

        public void Initialize(List<Class> classes, List<Room> rooms, List<Teacher> teachers)
        {
            for (int i = 0; i < PopulationSize; i++)
            {
                var chromosome = new ScheduleChromosome();
                chromosome.Randomize(classes, rooms, teachers);
                chromosome.Fitness = FitnessCalculator.CalculateFitness(chromosome, rooms, teachers);
                Population.Add(chromosome);
            }
        }

        public ScheduleChromosome Evolve(List<Class> classes, List<Room> rooms, List<Teacher> teachers)
        {
            Random rand = new Random();

            for (int i = 0; i < Generations; i++)
            {
                Population.Sort((x, y) => y.Fitness.CompareTo(x.Fitness));

                List<ScheduleChromosome> newPopulation = new List<ScheduleChromosome>();

                for (int j = 0; j < PopulationSize / 2; j++)
                {
                    var parent1 = Population[j];
                    var parent2 = Population[PopulationSize - j - 1];

                    var offspring = Crossover(parent1, parent2, rand);
                    Mutate(offspring, rooms, teachers, rand);
                    offspring.Fitness = FitnessCalculator.CalculateFitness(offspring, rooms, teachers);
                    newPopulation.Add(offspring);
                }

                Population = newPopulation;
            }

            Population.Sort((x, y) => y.Fitness.CompareTo(x.Fitness));
            return Population[0];
        }

        private ScheduleChromosome Crossover(ScheduleChromosome parent1, ScheduleChromosome parent2, Random rand)
        {
            var offspring = new ScheduleChromosome();

            foreach (var schedule in parent1.ClassSchedules)
            {
                if (rand.NextDouble() < 0.5)
                    offspring.ClassSchedules.Add(schedule);
                else
                    offspring.ClassSchedules.Add(parent2.ClassSchedules.Find(s => s.ClassId == schedule.ClassId));
            }

            return offspring;
        }

        private void Mutate(ScheduleChromosome chromosome, List<Room> rooms, List<Teacher> teachers, Random rand)
        {
            if (rand.NextDouble() < MutationRate)
            {
                var schedule = chromosome.ClassSchedules[rand.Next(chromosome.ClassSchedules.Count)];

                var availableRooms = new List<Room>();
                foreach (var r in rooms)
                {
                    if (r.Type == schedule.ClassId)
                        availableRooms.Add(r);
                }

                var availableTeachers = new List<Teacher>();
                foreach (var t in teachers)
                {
                    if (t.Id == schedule.TeacherId)
                        availableTeachers.Add(t);
                }

                if (availableRooms.Count > 0 && availableTeachers.Count > 0)
                {
                    var room = availableRooms[rand.Next(availableRooms.Count)];
                    var teacher = availableTeachers[rand.Next(availableTeachers.Count)];
                    var startTime = GenerateRandomStartTime(teacher.Availability, rand);
                    var endTime = startTime.AddHours(1); // Assuming 1-hour class

                    schedule.RoomId = room.Id;
                    schedule.TeacherId = teacher.Id;
                    schedule.StartTime = startTime;
                    schedule.EndTime = endTime;
                }
            }
        }

        private DateTime GenerateRandomStartTime(List<Tuple<DateTime, DateTime>> availability, Random rand)
        {
            var slot = availability[rand.Next(availability.Count)];
            int minutes = rand.Next((int)(slot.Item2 - slot.Item1).TotalMinutes);
            return slot.Item1.AddMinutes(minutes);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = "YourConnectionStringHere";
            var dbContext = new DatabaseContext(connectionString);

            var classes = dbContext.GetClasses();
            var rooms = dbContext.GetRooms();
            var teachers = dbContext.GetTeachers();

            GeneticAlgorithm ga = new GeneticAlgorithm(populationSize: 100, generations: 500, mutationRate: 0.05);
            ga.Initialize(classes, rooms, teachers);

            var bestSchedule = ga.Evolve(classes, rooms, teachers);

            foreach (var schedule in bestSchedule.ClassSchedules)
            {
                dbContext.SaveSchedule(schedule);
            }

            Console.WriteLine("Best schedule generated and saved to database.");
        }
    }
}
