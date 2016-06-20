using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Author:Chinatsu Kawakami
 * Date : June 17 ,2016
 * Student ID : 300821245
 * Description : This class is used to describe x and y cordinator 
 * versiotn 0.0.1: Initial class creation with Getter and Setter for x and y
 */
namespace PlayerProject
{
    /**
     *<summary> 
     * This class contains two properties x and y which are related to goespatial information for game objects
     * </summary>
     * @class Vector2
     * @property {float} x - defines the x cordinate
     * @property {float} y - defines the y cordinate
     *
     */
    public class Vector2
    {
        //PRIVATE INSTANCE VARIABLES (FIELDS)***********************************************************
        private float _x;
        private float _y;

 
        //PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public float x
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        public float y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }

        //CONSTRUCTOR********************************************************************************
        /**
         * <summary>
         ** This constructor takes two parameters : x and y which represent the x and y coordinates of an object 
         * </summary>
         * @constructor Vector2
         * @param {float} x -the x cordinate
         * @param {float} x -the y cordinate
         */
        public Vector2(float x = 0f, float y = 0f)
        {
            this.x = x;
            this.y = y;
        }
        //PUBLIC METHOD+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void Zero()
        {
            this.x = 0f;
            this.y = 0f;
        }
        
    }
}
