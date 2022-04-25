namespace Leitura_de_HashCode_e_equals.Entities
{
    class Student
    {
        public int StudentCode { get; set; }

        public Student(int studentCode)
        {
            StudentCode = studentCode;
        }

        public override int GetHashCode()
        {
            return StudentCode.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return StudentCode.Equals(other.StudentCode);
        }
    }
}
