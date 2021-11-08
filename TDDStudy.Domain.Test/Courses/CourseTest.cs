using Xunit;

namespace TDDStudy.Domain.Test.Courses
{
    public class CourseTest
    {
        /* Criar cursos
         *  
         *  Criar um curso com os seguintes dados:
         * 
         *   Nome, Carga Horaria, publico alvo e o valor do curso  
         */

        [Fact]
        public void Course_CreateCource_ReturnCourse()
        {
            var expectedCourse = new
            {
                Name = "Curso de TDD",
                Workload = (double)40.0,
                TargetAudience = "Estudantes",
                CourseValue = (decimal)100
            };

            var course = new Course(expectedCourse.Name, expectedCourse.Workload, expectedCourse.TargetAudience, expectedCourse.CourseValue);

            Assert.Equal(expectedCourse.Name, course.Name);
        }

    }
}
