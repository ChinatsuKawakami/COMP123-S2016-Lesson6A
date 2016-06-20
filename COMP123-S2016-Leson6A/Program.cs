using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author:Chinatsu Kawakami
 * Date : June 17 ,2016
 * Student ID : 300821245
 * Description : This program tests the Player and Enemy Classes
 * versiotn 0.0.2 Added Tostring method and  _calculateTergetAngle() method
 */
namespace PlayerProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Player greenPlayer = new PlayerProject.Player("green");
            greenPlayer.MoveForward();
           greenPlayer.Facing.x = -3.0f;
           greenPlayer.Facing.y = -3.0f;
            Console.WriteLine(greenPlayer.ToString());
            TouchingEnemy redEnemy = new TouchingEnemy("red");

          redEnemy.MoveForward();

            WaitForAnyKey();
        }
        /**
         * <summary>
         * Utility method to wait for console key press from the user
         * </summary>
         * 
         * @method WaitForAnyKey
         * @returns {void}
         */
        public static void WaitForAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
