namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Question 1

            //a) What is the difference between a class and a struct?
            //class:is a refrence type stored in heap, when Assignment it copies the refrence, support inhertance ,can be null , default constructor is available if none is defined, suitable for complex programs.
            //struct:is a value type stored in stack,  when assignment it copies the value, deosn't support inhertance ,cannot be null, default constructor is available all time, suitable for simple program.

            //b) Why are classes more suitable than structs for large application
            //Because classes support complex program as it support inhertance and avoids unnecessaray coping.
            #endregion

            #region Question 2

            //a) Which class is the parent class?
            //Shipment

            //b) Which class is the child class?
            //ExpressShipment

            //c) What members are inherited by ExpressShipment?
            //TrackingCode

            //d) Why is inheritance better than duplicating the same code in multiple classes?
            //Inheritance promotes code reuse, reduces duplication, makes the code easier to maintain, and allows common functionality to be defined once in the parent class and reused by multiple child classes.

            #endregion
            #endregion


        }
    }
}
