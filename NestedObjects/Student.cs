using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Legal first name of Student
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Legal first name of Student
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The assigned school email address
        /// </summary>
        public string SchoolEmail { get; set; }

        /// <summary>
        /// The student's date of birth (date only)
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// The student's primary phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The students assigned advisor
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }



    }
}
