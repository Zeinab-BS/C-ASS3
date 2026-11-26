namespace C_ASS3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1

            /*
             Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
             the second price (index 1).
            */

            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);


            #endregion

            #region Question2
            /*
             Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.  
            */
            //int[,] shelfCopies = new int[2, 2]
            //{
            //    {3,5 },
            //    {1,4},

            //};

            //Console.WriteLine(shelfCopies[1,0]);


            #endregion


            #region Question3
            /*
             Write a method called PrintWelcomeMessage that takes no parameters and prints
             "Welcome to the Library!". Call it from Main.
            */

            //PrintWelcomeMessage();




            #endregion


            #region Question4

            /*
             Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
             "Clean Code".  
            */

            //PrintBookTitle("Clean Code");



            #endregion


            #region Question5

            /*
             
             Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
             int pages = 400; and print pages afterward. What do you expect to see, and why?
             
            */

            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
            // excpected pages=400
            // becuase this is value type argument and we pass it by value so method took a copy from it not value its self

            #endregion






        }

        #region Question3Function
        //static void PrintWelcomeMessage()
        // {
        //     Console.WriteLine("Welcome to the Library!");
        // }

        #endregion


        #region Question4Function 

        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine($"Book title: {title}");
        //}

        #endregion

        #region Question5Function

        //static void AddBonusPages(int pages)
        //{
        //    pages += 50;
        //}

        #endregion



    }
}
