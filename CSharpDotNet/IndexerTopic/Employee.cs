namespace CSharpDotNet.IndexerTopic
{
    class Employee
    {
        int EmployeeID;
        string EmployeeName, Job, DepartmentName, Location;
        double Salary;

        /// <summary>
        /// Constructore of the class
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="EmployeeName"></param>
        /// <param name="Job"></param>
        /// <param name="DepartmentName"></param>
        /// <param name="Location"></param>
        /// <param name="Salary"></param>
        public Employee(int EmployeeID, string EmployeeName, string Job, string DepartmentName, string Location, double Salary)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
            this.Job = Job;
            this.DepartmentName = DepartmentName;
            this.Location = Location;
            this.Salary = Salary;
        }


        /// <summary>
        /// To make the class behave like a virtual array, indexer is being used (This is first indexers with Index as Parameter)
        /// return type is object, so that it can return any value for all different datatypes
        /// "this" keyword signifies this indexer is for the current class i.e. Employee class
        /// index is received as integer value
        /// </summary>
        public object this[int Index]
        {
            //During Get, the index values can be of any of our choice, since it's custom designed
            //For now, we have started it from 0 but we can stat it from 1 also (as per developers convenience)
            get
            {
                if (Index == 0) return EmployeeID;
                else if (Index == 1) return EmployeeName;
                else if (Index == 2) return Job;
                else if (Index == 3) return DepartmentName;
                else if (Index == 4) return Location;
                else if (Index == 5) return Salary;
                else return null;
            }
            set
            {
                //While Set, "value" keyword is being used to receive the value from the outer class
                //Basically value is an implicit variable that provides access to the value provided by the user
                //Also value has to be converted into the specific datatype of the attribute, since value is object type
                if (Index == 0) EmployeeID = (int)value;
                else if (Index == 1) EmployeeName = (string)value;
                else if (Index == 2) Job = (string)value;
                else if (Index == 3) DepartmentName = (string)value;
                else if (Index == 4) Location = (string)value;
                else if (Index == 5) Salary = (double)value;
            }
        }


        /// <summary>
        /// To make the class behave like a virtual array, indexer is being used (This is second indexers with PropertyName as Parameter)
        /// return type is object, so that it can return any value for all different datatypes
        /// "this" keyword signifies this indexer is for the current class i.e. Employee class
        /// index is received as string value
        /// </summary>
        public object this[string PropertyName]
        {
            //During Get, the PropertyName will be the name of the properties 
            //Based on PropertyName, we'll fetch the data for Employee;
            get
            {
                if (PropertyName.ToUpper() == "EMPLOYEEID") return EmployeeID;
                else if (PropertyName.ToUpper() == "EMPLOYEENAME") return EmployeeName;
                else if (PropertyName.ToUpper() == "JOB") return Job;
                else if (PropertyName.ToUpper() == "DEPARTMENTNAME") return DepartmentName;
                else if (PropertyName.ToUpper() == "LOCATION") return Location;
                else if (PropertyName.ToUpper() == "SALARY") return Salary;
                else return null;
            }
            set
            {
                //While Set, "value" keyword is being used to receive the value from the outer class
                //Basically value is an implicit variable that provides access to the value provided by the user
                //Also value has to be converted into the specific datatype of the attribute, since value is object type
                if (PropertyName.ToUpper() == "EMPLOYEEID") EmployeeID = (int)value;
                else if (PropertyName.ToUpper() == "EMPLOYEENAME") EmployeeName = (string)value;
                else if (PropertyName.ToUpper() == "JOB") Job = (string)value;
                else if (PropertyName.ToUpper() == "DEPARTMENTNAME") DepartmentName = (string)value;
                else if (PropertyName.ToUpper() == "LOCATION") Location = (string)value;
                else if (PropertyName.ToUpper() == "SALARY") Salary = (double)value;
            }
        }



    }
}
