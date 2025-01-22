namespace Assignment_06_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 

            #region Q01 : What is the primary purpose of an interface in C#?
            //a) To provide a way to implement multiple inheritance
            //b) To define a blueprint for a class
            //c) To declare abstract methods and properties
            //d) To create instances of objects


            // The Answer : b) To define a blueprint for a class


            #endregion

            #region Q02 : Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            //b) protected
            //c) internal
            //d) public

            // The Answer : a) private

            #endregion

            #region Q03 : Can an interface contain fields in C#?
            //a) Yes
            //b) No
            //c) Only if they are static
            //d) Only if they are readonly



            // The Answer :b) No
            #endregion

            #region Q04 :In C#, can an interface inherit from another interface?
            //a) No, interfaces cannot inherit from each other
            //b) Yes, interfaces can inherit from multiple interfaces
            //c) Yes, but only if they have the same methods
            //d) Only if the interfaces are in the same namespace


            // The Answer :b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q05 : Which keyword is used to implement an interface in a class in C#?
            //a) inherit
            //b) use
            //c) extends
            //d) implements


            // The Answer :d) implements
            #endregion

            #region Q06 : Can an interface contain static methods in C#?
            //a) Yes
            //b) No
            //c) Only if the interface is sealed
            //d) Only if the methods are private


            // The Answer :a) Yes
            #endregion

            #region Q07 : In C#, can an interface have explicit access modifiers for its members?
            //a) Yes, for all members
            //b) No, all members are implicitly public
            //c) Yes, but only for abstract members
            //d) Only if the interface is sealed


            // The Answer :b) No, all members are implicitly public
            #endregion

            #region Q08 : What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access
            //b) To provide a clear separation between interface and class members
            //c) To allow multiple classes to implement the same interface
            //d) To speed up method resolution



            // The Answer :b) To provide a clear separation between interface and class members
            #endregion

            #region Q09 : In C#, can an interface have a constructor?
            //a) Yes, but it must be private
            //b) No, interfaces cannot have constructors
            //c) Yes, but only if the interface is sealed
            //d) Only if the constructor is static


            // The Answer :d) Only if the constructor is static
            #endregion

            #region Q10 : How can a C# class implement multiple interfaces?
            //a) By using the "implements" keyword
            //b) By using the "extends" keyword
            //c) By separating interface names with commas
            //d) A class cannot implement multiple interfaces


            // The Answer :c) By separating interface names with commas
            #endregion

            #endregion

            #region Part 02

            #region Q01 : 
            //Circle circle = new Circle(10);
            //circle.DisplayShapeInfo();

            //Rectangle Rect = new Rectangle(10, 20);
            //Rect.DisplayShapeInfo();

            #endregion

            #region Q02 

            //IAuthenticationService Auth = new BasicAuthenticationService();
            //Console.WriteLine(Auth.AuthenticateUser("Adel", "12345"));
            //Console.WriteLine(Auth.AuthorizeUser("Adel", "Admin"));


            #endregion


            #endregion

        }
    }
}
