namespace Homework_1
{
    class Data
    {

        //singleton
        private static Data instance = null;
        private static readonly object padLock = new object();

        private Data()
        {
        }

        public static Data Instance
        {
            get
            {
                lock (padLock)
                {
                    if (instance == null)
                    {
                        instance = new Data();
                    }
                    return instance;
                }
            }
        }


        // ------------------------------------ task 53 ------------------------------------//

        private static Node<Task53.Grade> gradeItay =
                    new Node<Task53.Grade>(new Task53.Grade(8819516, 80),
                    new Node<Task53.Grade>(new Task53.Grade(8819517, 85),
                    new Node<Task53.Grade>(new Task53.Grade(8819518, 90))));


        private static Node<Task53.Grade> gradeMiki =
        new Node<Task53.Grade>(new Task53.Grade(8819516, 79.3),
        new Node<Task53.Grade>(new Task53.Grade(8819517, 87.4),
        new Node<Task53.Grade>(new Task53.Grade(8819518, 88.25))));




        public readonly Node<Task53.Student> GradeDB = new Node<Task53.Student>(new Task53.Student("Itay", 987264534, 2020, gradeItay),
                new Node<Task53.Student>(new Task53.Student("Miki", 487264534, 2020, gradeMiki)));
        // ------------------------------------ task 53 ------------------------------------//


        // ------------------------------------ task 48 ------------------------------------//

        public readonly Node<Task48.TupleStrInt> Representation =
                new Node<Task48.TupleStrInt>(new Task48.TupleStrInt("R", 1),
                new Node<Task48.TupleStrInt>(new Task48.TupleStrInt("L", 3),
                new Node<Task48.TupleStrInt>(new Task48.TupleStrInt("S", 4))));
    
        // ------------------------------------ task 48 ------------------------------------//


        // ------------------------------------ task 2 ------------------------------------//

        public readonly Node<int> Sequence =
                new Node<int>(3,
                new Node<int>(4,
                new Node<int>(5,
                new Node<int>(12,
                new Node<int>(19,
                new Node<int>(20,
                new Node<int>(100,
                new Node<int>(101,
                new Node<int>(102,
                new Node<int>(103,
                new Node<int>(104)))))))))));

        // ------------------------------------ task 2 ------------------------------------//


        // ------------------------------------ task 14 ------------------------------------//
        private static readonly Task14.Room[] Rooms = new Task14.Room[]
        {
            new Task14.Room("bedroom",1,1),
            new Task14.Room("bathroom",2,2),
            new Task14.Room("kitchen",3,3),
            new Task14.Room("basement",4,4),

            new Task14.Room("bedroom",1,2),
            new Task14.Room("bathroom",3,4),
            new Task14.Room("kitchen",5,6),
            new Task14.Room("basement",7,8),

            new Task14.Room("bedroom",10.1,10.4),
            new Task14.Room("bathroom",10.5,11.4),
            new Task14.Room("kitchen",10.4,10.12),
            new Task14.Room("basement",1,12.1),

            new Task14.Room("bedroom",1,1),
            new Task14.Room("bathroom",2,2),
            new Task14.Room("kitchen",3,3),
            new Task14.Room("basement",4,4),

            new Task14.Room("bedroom",1,2),
            new Task14.Room("bathroom",3,4),
            new Task14.Room("kitchen",5,6),
            new Task14.Room("basement",7,8),

            new Task14.Room("bedroom",10.1,10.4),
            new Task14.Room("bathroom",10.5,11.4),
            new Task14.Room("kitchen",10.4,10.12),
            new Task14.Room("basement",1,12.1),

            new Task14.Room("bedroom",1,2),
            new Task14.Room("bathroom",3,4),
            new Task14.Room("kitchen",5,6),
            new Task14.Room("basement",7,8),

            new Task14.Room("bedroom",10.1,10.4),
            new Task14.Room("bathroom",10.5,11.4),
            new Task14.Room("kitchen",10.4,10.12),
            new Task14.Room("basement",1,12.1),


        };

        private static readonly Task14.Address[] Addresses = new Task14.Address[]
        {
            new Task14.Address("moshe dayan","ramat-gan", 6),


            new Task14.Address("abarbanel","petah-tikva", 6),


            new Task14.Address("david grosman","jerusalem", 6),

            new Task14.Address("davidka","jerusalem", 6),

        };

        private static readonly Task14.Apartment[] Apartments = new Task14.Apartment[]
        {
            new Task14.Apartment("Itay", new Task14.Room[]{Rooms[0],Rooms[1],Rooms[2],Rooms[3]}),
            new Task14.Apartment("Miki", new Task14.Room[]{Rooms[4],Rooms[5],Rooms[6],Rooms[7]}),
            new Task14.Apartment("Zvi", new Task14.Room[]{Rooms[8],Rooms[9],Rooms[10],Rooms[11]}),
            new Task14.Apartment("Josef", new Task14.Room[]{Rooms[12],Rooms[13],Rooms[14],Rooms[15]}),
            new Task14.Apartment("Mika", new Task14.Room[]{Rooms[16],Rooms[17],Rooms[18],Rooms[19]}),
            new Task14.Apartment("Riki", new Task14.Room[]{Rooms[20],Rooms[21],Rooms[22],Rooms[23]}),
            new Task14.Apartment("Ella", new Task14.Room[]{Rooms[24],Rooms[25],Rooms[26],Rooms[27]}),
            new Task14.Apartment("Jake", new Task14.Room[]{Rooms[28],Rooms[29],Rooms[30],Rooms[31]}),

        };

        public readonly Task14.Building[] Buildings = new Task14.Building[]
        {
            new Task14.Building(new Task14.Apartment[] {Apartments[0],Apartments[1]},Addresses[0]),
            new Task14.Building(new Task14.Apartment[] {Apartments[2],Apartments[3]},Addresses[1]),
            new Task14.Building(new Task14.Apartment[] {Apartments[4],Apartments[5]},Addresses[2]),
            new Task14.Building(new Task14.Apartment[] {Apartments[6],Apartments[7]},Addresses[3]),


        };


        // ------------------------------------ task 14 ------------------------------------//




    }
}
