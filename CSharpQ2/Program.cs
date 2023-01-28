class Program{

    public static void Main(string[] args){

        Console.WriteLine("Welcome to the STUDENT RESULT SHEET:\n");

        const int rows = 2;
        const int cols = 4;

        int[] student = new int[rows];
        int[,] table = new int[rows, cols];

        for(int i = 1; i < rows; i++){

            Console.Write("Please enter student number: ");
            student[i] = Convert.ToInt32(Console.ReadLine());

            for(int j = 0; j < cols; j++){
                Console.Write("Enter T1: ");
                table[i, j] = Convert.ToInt32(Console.ReadLine());
            
            }
        }

        Console.WriteLine();

        Console.Write("StdNo" + "\tT1" + "\tT2" + "\tAssign" + "\tExam" + "\tFinal");

        for(int i = 1; i < rows; i++){

            Console.Write("\n" + student[i]);
            
            for(int j = 0; j < cols; j++){

                Console.Write("\t" + table[i, j]);
            }
        }
    }
}