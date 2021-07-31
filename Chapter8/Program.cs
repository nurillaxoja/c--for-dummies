using System;
using System.Collections.Generic;


namespace Chapter8
{
    class Program
    {
        /*205*/
        static void Main(string[] args)
        {
            Console.WriteLine("Creating queue either priority:");
            PriorityQueue<Package> pq = new PriorityQueue<Package>();
            Console.WriteLine("Inseting random number of (0-20)" +
                "Random packages in queue");
            Package pack;
            PackageFactory fact = new PackageFactory();
            Random rand = new Random();
            int numToCreate = rand.Next(20);
            Console.WriteLine("\tCreating {0} number of packages: "
                , numToCreate);
            for (int i = 0; i < numToCreate; i++)
            {
                Console.WriteLine("\t\tGeneratin and adding " +
                    "random number of packages {0}", i);
                pack = fact.CreatePackage();
                Console.WriteLine("with priority {0}", pack.Priority);
                pq.Enqueue(pack);
            }
            Console.WriteLine("What was generated:");
            int total = pq.Count;

            Console.WriteLine("Generated {0} pakages.", total);
            Console.WriteLine("Extracting random number of " +
                "packages pakages: 0-20:");
            int numToRemove = rand.Next(20);
            Console.WriteLine("Extracting {0} packages",
                numToRemove);
            for (int i = 0; i < numToRemove; i++)
            {
                pack = pq.Dequeue();
                if (pack != null)
                {
                    Console.WriteLine("\t\tDelivering package" +
                        "with priority {0}", pack.Priority);
                }
            }
            Console.WriteLine("Deliverd {0} packages",
                total - pq.Count);




            Console.ReadLine();
        }
    }


    enum Priority
    {
        Low, Medium, High
    }
    interface IPrioritizable
    {
        Priority Priority { get; }
    }
    class PriorityQueue<T>
        where T : IPrioritizable
    {
        private Queue<T> _queueHigh = new Queue<T>();
        private Queue<T> _queueMedium = new Queue<T>();
        private Queue<T> _queueLow = new Queue<T>();

        public void Enqueue(T item)
        {
            switch (item.Priority)
            {
                case Priority.Low:
                    break;
                case Priority.Medium:
                    break;
                case Priority.High:
                    break;
                default:
                    throw new
                        ArgumentOutOfRangeException(
                        item.Priority.ToString(),
                        "Wrong priority in PriorityQueue.Enqueue");
            }
        }
        public T Dequeue()
        {
            Queue<T> queueTop = TopQueue();
            if (queueTop != null && queueTop.Count > 0)
            {
                return queueTop.Dequeue();
            }
            return default(T);
        }
        private Queue<T> TopQueue()
        {
            if (_queueHigh.Count > 0)
            {
                return _queueHigh;
            }
            if (_queueMedium.Count > 0)
            {
                return _queueMedium;
            }
            if (_queueLow.Count > 0)
            {
                return _queueLow;
            }
            return _queueLow;
        }
        public bool IsEmpty()
        {
            return (_queueHigh.Count == 0) &
                (_queueMedium.Count == 0) &
                (_queueLow.Count == 0);
        }
        public int Count
        {
            get
            {
                return _queueLow.Count + _queueMedium.Count + _queueHigh.Count;
            }
        }
    }

    class Package : IPrioritizable
    {
        private Priority priority;

        public Package(Priority priority)
        {
            this.priority = priority;
        }
        public Priority Priority
        {
            get { return priority; }
        }
    }
    class PackageFactory
    {
        Random _randGen = new Random();
        public Package CreatePackage()
        {
            int rand = _randGen.Next(3);
            return new Package((Priority)rand);
        }
    }
}       
