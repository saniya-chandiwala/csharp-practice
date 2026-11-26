namespace StudentIdGenLib
{
    #region
    /// <summary>
    /// student class for generating student id
    /// </summary>
    #endregion
    public class Student
    {
        static int idCounter = 1;

        public string StdName { get; set; }
        public string StdCourse { get; set; }

        // id generation method
        public int GenerateId()
        {
            return idCounter++;
         }
            
        }
    }
