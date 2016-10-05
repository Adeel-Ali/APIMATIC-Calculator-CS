/*
 * APIMATICCalculator.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 10-05-2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATICCalculator.PCL;

namespace APIMATICCalculator.PCL.Models
{
    public class GetCalculateInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private OperationTypeEnum operation;
        private double x;
        private double y;

        /// <summary>
        /// The operator to apply on the variables
        /// </summary>
        [JsonProperty("operation", ItemConverterType = typeof(StringValuedEnumConverter))]
        public OperationTypeEnum Operation 
        { 
            get 
            {
                return this.operation; 
            } 
            set 
            {
                this.operation = value;
                onPropertyChanged("Operation");
            }
        }

        /// <summary>
        /// The LHS value
        /// </summary>
        [JsonProperty("x")]
        public double X 
        { 
            get 
            {
                return this.x; 
            } 
            set 
            {
                this.x = value;
                onPropertyChanged("X");
            }
        }

        /// <summary>
        /// The RHS value
        /// </summary>
        [JsonProperty("y")]
        public double Y 
        { 
            get 
            {
                return this.y; 
            } 
            set 
            {
                this.y = value;
                onPropertyChanged("Y");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 