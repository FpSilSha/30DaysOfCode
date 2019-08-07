using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    class Day12
    {
        /*
         You are given two classes, Person and Student, where Person is the base class and Student is the derived class. 
         Completed code for Person and a declaration for Student are provided for you in the editor. 
         Observe that Student inherits all the properties of Person.
         
         Complete the Student class by writing the following:

         A Student class constructor, which has  parameters:
         A string, firstName.
         A string, lastName.
         An integer, id.
         An integer array (or vector) of test scores, scores.
         A char calculate() method that calculates a Student object's average and returns the grade character representative of their calculated average:
         O 90<= a <=100
         E 80<= a <=90
         A 70<= a <=80
         P 55<= a <=70
         D 40<= a <=55
         T   a < 40
         
         */

            class Person{
	                 protected string firstName;
	                 protected string lastName;
	                 protected int id;
	
	                public Person(){}
	                public Person(string firstName, string lastName, int identification){
		        	this.firstName = firstName;
		        	this.lastName = lastName;
			        this.id = identification;
                	}
	                public void printPerson(){
	            	Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	                }
            }

        class Student : Person
        {
            
            int[] scores;
            
            public Student(string firstName, string lastName, int id, int[] testScores)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = id;
                scores = testScores;
            }

            public char Calculate()
            {
                double average = scores.Average();
                
                if(90 <= average)
                {
                    return 'O';
                } else if(80 <= average && average < 90)
                {
                    return 'E';
                } else if (70 <= average && average < 80)
                {
                    return 'A';
                } else if (55 <= average && average < 70)
                {
                    return 'P';
                } else if (40 <= average && average < 55)
                {
                    return 'D';
                } else 
                {
                    return 'T';
                }
                     
            }

            

        }

        
        
            public void Run()
            {
                string[] inputs = Console.ReadLine().Split();
                string firstName = inputs[0];
                string lastName = inputs[1];
                int id = Convert.ToInt32(inputs[2]);
                int numScores = Convert.ToInt32(Console.ReadLine());
                inputs = Console.ReadLine().Split();
                int[] scores = new int[numScores];
                for (int i = 0; i < numScores; i++)
                {
                    scores[i] = Convert.ToInt32(inputs[i]);
                }

                Student s = new Student(firstName, lastName, id, scores);
                s.printPerson();
                Console.WriteLine("Grade: " + s.Calculate() + "\n");
            }


    }
}
