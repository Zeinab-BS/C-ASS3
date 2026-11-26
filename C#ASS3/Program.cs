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

            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            // excpected pages=400
            // becuase this is value type argument and we pass it by value so method took a copy from it not value its self

            #endregion

            #region Question6
            /*
             Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
             with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to
             see, and why?
             
            */

            //double[] prices = { 25.2, 40.4 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            //expected prices[0]=20.2
            // becuase this is refernce type argument and we pass it by value so method took a copy of address of prices so they 
            // both now refer to the same array im memory and any modification affect on the original array 


            #endregion



            #region Question7
            /*
             Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
             Call it and print pages afterward. How is the result different from question 5?
             
            */

            //int pages = 400;
            //AddBonusPages(ref pages);
            //Console.WriteLine(pages);
            // expected :450
            // this is value type and we pass it by refernce that means method can  access original variable not a copy of it 
            // so any changes will affect on it 



            #endregion


            #region Question8
            /*
             Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
             new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length
             afterward.
            */
            double[] prices = { 40.2, 20.4 };
            ReplaceArray(ref prices);
            Console.WriteLine(prices.Length);//3
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

        #region Question6Function

        //static void  ApplyDiscount(double[] prices)
        //{
        //    prices[0] -= 5;
        //}


        #endregion


        #region Question7Function


        //static void AddBonusPages(ref int pages)
        //{
        //    pages += 50;
        //}


        #endregion


        #region Question8Function

        //static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double[] { 10.0, 12.5, 15.0 };
        //}



        #endregion



    }
}
