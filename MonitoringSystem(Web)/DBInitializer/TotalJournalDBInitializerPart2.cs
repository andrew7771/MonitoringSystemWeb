using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonitoringSystemModel;
using System.Data.Entity;

namespace MonitoringSystem_Web_.DBInitializer
{
    public partial class TotalJournalDBInitializer : DropCreateDatabaseAlways<TotalJournalContextWeb>
    {
        protected void GroupInit(ref TotalJournalContextWeb context)
        {
            //номер группы           номер курса
            context.Groups.Add(new Group() { GroupID = "611п", CourseNumber = 1 });
            context.Groups.Add(new Group() { GroupID = "612п", CourseNumber = 1 });
            context.Groups.Add(new Group() { GroupID = "621п", CourseNumber = 2 });
            context.Groups.Add(new Group() { GroupID = "622п", CourseNumber = 2 });
            context.Groups.Add(new Group() { GroupID = "611пст", CourseNumber = 2 });
            context.Groups.Add(new Group() { GroupID = "631п", CourseNumber = 3 });
            context.Groups.Add(new Group() { GroupID = "632п", CourseNumber = 3 });
            context.Groups.Add(new Group() { GroupID = "621пст", CourseNumber = 3 });
            context.Groups.Add(new Group() { GroupID = "641п", CourseNumber = 4 });
            context.Groups.Add(new Group() { GroupID = "642п", CourseNumber = 4 });
            context.Groups.Add(new Group() { GroupID = "631пст", CourseNumber = 4 });
        }
                        
        protected void TeacherInit(ref TotalJournalContextWeb context)
        {
            ////                                  TeachersID++    
            context.Teachers.Add(new Teacher() { TeacherID = 1, FirstName = "Павел", MiddleName = "Александрович", LastName = "Лучшев", AcadDegree = " к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 2, FirstName = "Мария", MiddleName = "Александровна", LastName = "Данова", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 3, FirstName = "Оксана", MiddleName = "Вадимовна", LastName = "Лучшева", AcadDegree = "ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 4, FirstName = "Юрий", MiddleName = "Семенович", LastName = "Манжос", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 5, FirstName = "Людмила", MiddleName = "Васильевна", LastName = "Мандрикова", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 6, FirstName = "Николай", MiddleName = "Григорьевич", LastName = "Мокляк", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 7, FirstName = "Вероника", MiddleName = "Альбертовна", LastName = "Постернакова", AcadDegree = "ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 8, FirstName = "Лариса", MiddleName = "Федоровна", LastName = "Пудовкина", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 9, FirstName = "Александр", MiddleName = "Александрович", LastName = "Резуненко", AcadDegree = " ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 10, FirstName = "Сергей", MiddleName = "Владимирович", LastName = "Россоха", AcadDegree = "к.т.н.,ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 11, FirstName = "Евгения", MiddleName = "Витальевна", LastName = "Соколова", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 12, FirstName = "Илона", MiddleName = "Владимировна", LastName = "Шевченко", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 13, FirstName = "Юлия", MiddleName = "Анатольевна", LastName = "Кузнецова", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 14, FirstName = "Елена", MiddleName = "Георгиевна", LastName = "Кириленко", AcadDegree = "к.пед.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 15, FirstName = "Владислав", MiddleName = "Анатольевич", LastName = "Демьяненко", AcadDegree = "ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 16, FirstName = "Татьяна", MiddleName = "Григорьевна", LastName = "Дегтярева", AcadDegree = "ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 17, FirstName = "Надежда", MiddleName = "Григорьевна", LastName = "Голубь", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 18, FirstName = "Олег", MiddleName = "Николаевич", LastName = "Волошин", AcadDegree = "ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 19, FirstName = "Лина", MiddleName = "Алексеевна", LastName = "Волобуева", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 20, FirstName = "Игорь", MiddleName = "Владимирович", LastName = "Шостак", AcadDegree = "д.т.н.,профессор" });
            context.Teachers.Add(new Teacher() { TeacherID = 21, FirstName = "Игорь", MiddleName = "Борисович", LastName = "Туркин", AcadDegree = "д.т.н.,профессор" });
            context.Teachers.Add(new Teacher() { TeacherID = 22, FirstName = "Борис", MiddleName = "Михайлович", LastName = "Конорев", AcadDegree = "д.т.н.,профессор" });

        }
        protected void MarkInit(ref TotalJournalContextWeb context)
        {
            //// оценки
            context.Marks.Add(new Mark() { MarkID = 1, LabNumber = 1, RecordBookNumberID = "436001", TheMark = 5, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 2, LabNumber = 2, RecordBookNumberID = "436001", TheMark = 4, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 3, LabNumber = 3, RecordBookNumberID = "436001", TheMark = 3, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });

            context.Marks.Add(new Mark() { MarkID = 4, LabNumber = 1, RecordBookNumberID = "436001", TheMark = 1, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 5, LabNumber = 2, RecordBookNumberID = "436001", TheMark = 1, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 6, LabNumber = 3, RecordBookNumberID = "436001", TheMark = 1, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });

            context.Marks.Add(new Mark() { MarkID = 7, LabNumber = 1, RecordBookNumberID = "436001", TheMark = 5, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 8, LabNumber = 2, RecordBookNumberID = "436001", TheMark = 5, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 9, LabNumber = 3, RecordBookNumberID = "436001", TheMark = 5, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });

            context.Marks.Add(new Mark() { MarkID = 10, LabNumber = 1, RecordBookNumberID = "436001", TheMark = 4, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 11, LabNumber = 2, RecordBookNumberID = "436001", TheMark = 4, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 12, LabNumber = 3, RecordBookNumberID = "436001", TheMark = 4, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });




            context.Marks.Add(new Mark() { MarkID = 13, LabNumber = 1, RecordBookNumberID = "436002", TheMark = 5, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 14, LabNumber = 2, RecordBookNumberID = "436002", TheMark = 5, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 15, LabNumber = 3, RecordBookNumberID = "436002", TheMark = 5, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });

            context.Marks.Add(new Mark() { MarkID = 16, LabNumber = 1, RecordBookNumberID = "436002", TheMark = 4, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 17, LabNumber = 2, RecordBookNumberID = "436002", TheMark = 4, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 18, LabNumber = 3, RecordBookNumberID = "436002", TheMark = 4, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });

            context.Marks.Add(new Mark() { MarkID = 19, LabNumber = 1, RecordBookNumberID = "436002", TheMark = 3, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 20, LabNumber = 2, RecordBookNumberID = "436002", TheMark = 5, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 21, LabNumber = 3, RecordBookNumberID = "436002", TheMark = 4, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });

            context.Marks.Add(new Mark() { MarkID = 22, LabNumber = 1, RecordBookNumberID = "436002", TheMark = 4, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 23, LabNumber = 2, RecordBookNumberID = "436002", TheMark = 5, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 24, LabNumber = 3, RecordBookNumberID = "436002", TheMark = 4, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });




            context.Marks.Add(new Mark() { MarkID = 25, LabNumber = 1, RecordBookNumberID = "436003", TheMark = 4, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 26, LabNumber = 2, RecordBookNumberID = "436003", TheMark = 4, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 27, LabNumber = 3, RecordBookNumberID = "436003", TheMark = 4, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });

            context.Marks.Add(new Mark() { MarkID = 28, LabNumber = 1, RecordBookNumberID = "436003", TheMark = 5, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 29, LabNumber = 2, RecordBookNumberID = "436003", TheMark = 3, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 30, LabNumber = 3, RecordBookNumberID = "436003", TheMark = 5, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });

            context.Marks.Add(new Mark() { MarkID = 31, LabNumber = 1, RecordBookNumberID = "436003", TheMark = 4, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 32, LabNumber = 2, RecordBookNumberID = "436003", TheMark = 5, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 33, LabNumber = 3, RecordBookNumberID = "436003", TheMark = 5, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });

            context.Marks.Add(new Mark() { MarkID = 34, LabNumber = 1, RecordBookNumberID = "436003", TheMark = 5, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 35, LabNumber = 2, RecordBookNumberID = "436003", TheMark = 4, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 36, LabNumber = 3, RecordBookNumberID = "436003", TheMark = 3, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
        }
        protected void AttendanceInit(ref TotalJournalContextWeb context)
        {
            context.Attendances.Add(new Attendance() { AttendanceID = 1, RecordBookNumberID = "436001", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = true });
            context.Attendances.Add(new Attendance() { AttendanceID = 2, RecordBookNumberID = "436001", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = false });
            context.Attendances.Add(new Attendance() { AttendanceID = 3, RecordBookNumberID = "436001", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = true });

            context.Attendances.Add(new Attendance() { AttendanceID = 4, RecordBookNumberID = "436001", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = false });
            context.Attendances.Add(new Attendance() { AttendanceID = 5, RecordBookNumberID = "436001", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });
            context.Attendances.Add(new Attendance() { AttendanceID = 6, RecordBookNumberID = "436001", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });

            context.Attendances.Add(new Attendance() { AttendanceID = 7, RecordBookNumberID = "436001", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = true });
            context.Attendances.Add(new Attendance() { AttendanceID = 8, RecordBookNumberID = "436001", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = true });
            context.Attendances.Add(new Attendance() { AttendanceID = 9, RecordBookNumberID = "436001", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = false });

            context.Attendances.Add(new Attendance() { AttendanceID = 10, RecordBookNumberID = "436001", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = false });
            context.Attendances.Add(new Attendance() { AttendanceID = 11, RecordBookNumberID = "436001", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = false });
            context.Attendances.Add(new Attendance() { AttendanceID = 12, RecordBookNumberID = "436001", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = true });



            context.Attendances.Add(new Attendance() { AttendanceID = 13, RecordBookNumberID = "436002", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = true });
            context.Attendances.Add(new Attendance() { AttendanceID = 14, RecordBookNumberID = "436002", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = false });
            context.Attendances.Add(new Attendance() { AttendanceID = 15, RecordBookNumberID = "436002", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = false });

            context.Attendances.Add(new Attendance() { AttendanceID = 16, RecordBookNumberID = "436002", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });
            context.Attendances.Add(new Attendance() { AttendanceID = 17, RecordBookNumberID = "436002", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });
            context.Attendances.Add(new Attendance() { AttendanceID = 18, RecordBookNumberID = "436002", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });

            context.Attendances.Add(new Attendance() { AttendanceID = 19, RecordBookNumberID = "436002", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = false });
            context.Attendances.Add(new Attendance() { AttendanceID = 20, RecordBookNumberID = "436002", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = true });
            context.Attendances.Add(new Attendance() { AttendanceID = 21, RecordBookNumberID = "436002", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = false });

            context.Attendances.Add(new Attendance() { AttendanceID = 22, RecordBookNumberID = "436002", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = false });
            context.Attendances.Add(new Attendance() { AttendanceID = 23, RecordBookNumberID = "436002", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = false });
            context.Attendances.Add(new Attendance() { AttendanceID = 24, RecordBookNumberID = "436002", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = true });



            context.Attendances.Add(new Attendance() { AttendanceID = 25, RecordBookNumberID = "436003", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = false });
            context.Attendances.Add(new Attendance() { AttendanceID = 26, RecordBookNumberID = "436003", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = false });
            context.Attendances.Add(new Attendance() { AttendanceID = 27, RecordBookNumberID = "436003", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = true });

            context.Attendances.Add(new Attendance() { AttendanceID = 28, RecordBookNumberID = "436003", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });
            context.Attendances.Add(new Attendance() { AttendanceID = 29, RecordBookNumberID = "436003", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });
            context.Attendances.Add(new Attendance() { AttendanceID = 30, RecordBookNumberID = "436003", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = false });

            context.Attendances.Add(new Attendance() { AttendanceID = 31, RecordBookNumberID = "436003", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = true });
            context.Attendances.Add(new Attendance() { AttendanceID = 32, RecordBookNumberID = "436003", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = false });
            context.Attendances.Add(new Attendance() { AttendanceID = 33, RecordBookNumberID = "436003", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = false });

            context.Attendances.Add(new Attendance() { AttendanceID = 34, RecordBookNumberID = "436003", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = true });
            context.Attendances.Add(new Attendance() { AttendanceID = 35, RecordBookNumberID = "436003", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = false });
            context.Attendances.Add(new Attendance() { AttendanceID = 36, RecordBookNumberID = "436003", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = true });

        }
        protected void ModuleInit(ref TotalJournalContextWeb context)
        {
            context.Modules.Add(new Module() { ModuleID = 1, SubjectID = 35, RecordBookNumberID = "436001", ModulePoint = 10, ModuleNumber = 1, });
            context.Modules.Add(new Module() { ModuleID = 2, SubjectID = 32, RecordBookNumberID = "436001", ModulePoint = 8, ModuleNumber = 1 });
            context.Modules.Add(new Module() { ModuleID = 3, SubjectID = 34, RecordBookNumberID = "436001", ModulePoint = 9, ModuleNumber = 1 });
            context.Modules.Add(new Module() { ModuleID = 4, SubjectID = 33, RecordBookNumberID = "436001", ModulePoint = 9, ModuleNumber = 1 });

            context.Modules.Add(new Module() { ModuleID = 5, SubjectID = 35, RecordBookNumberID = "436002", ModulePoint = 7, ModuleNumber = 1 });
            context.Modules.Add(new Module() { ModuleID = 6, SubjectID = 32, RecordBookNumberID = "436002", ModulePoint = 8, ModuleNumber = 1 });
            context.Modules.Add(new Module() { ModuleID = 7, SubjectID = 34, RecordBookNumberID = "436002", ModulePoint = 9, ModuleNumber = 1 });
            context.Modules.Add(new Module() { ModuleID = 8, SubjectID = 34, RecordBookNumberID = "436002", ModulePoint = 10, ModuleNumber = 1 });

            context.Modules.Add(new Module() { ModuleID = 9, SubjectID = 35, RecordBookNumberID = "436003", ModulePoint = 10, ModuleNumber = 1 });
            context.Modules.Add(new Module() { ModuleID = 10, SubjectID = 32, RecordBookNumberID = "436003", ModulePoint = 8, ModuleNumber = 1 });
            context.Modules.Add(new Module() { ModuleID = 11, SubjectID = 34, RecordBookNumberID = "436003", ModulePoint = 10, ModuleNumber = 1 });
            context.Modules.Add(new Module() { ModuleID = 12, SubjectID = 34, RecordBookNumberID = "436003", ModulePoint = 9, ModuleNumber = 1 });
        }
        protected void SubjectCPInit(ref TotalJournalContextWeb context)
        {
            context.SubjectCPs.Add(new SubjectCP() { SubjectCP_ID = 1, SubjectCPName = "Основы программирования(КП)", Term = 3, TeacherID = 1, });
            context.SubjectCPs.Add(new SubjectCP() { SubjectCP_ID = 2, SubjectCPName = "Объектно-ориентированное программирование(КП)", Term = 4, TeacherID = 1 });
            context.SubjectCPs.Add(new SubjectCP() { SubjectCP_ID = 3, SubjectCPName = "Алгоритмы и структуры данных(КП)", Term = 5, TeacherID = 1 });
            context.SubjectCPs.Add(new SubjectCP() { SubjectCP_ID = 4, SubjectCPName = "Операционные системы(КП)", Term = 6, TeacherID = 1 });
            context.SubjectCPs.Add(new SubjectCP() { SubjectCP_ID = 5, SubjectCPName = "Базы данных(КП)", Term = 7, TeacherID = 1 });
            context.SubjectCPs.Add(new SubjectCP() { SubjectCP_ID = 6, SubjectCPName = "Проектирование распределенных систем ЭВМ(КП)", Term = 8, TeacherID = 1 });
        }
        protected void CourseProjectLineInit(ref TotalJournalContextWeb context)
        {
            context.CourseProjectLines.Add(new CourseProjectLine() { CourseProjectLineID = 1, RecordBookNumberID = "436001", SubjectCP_ID = 6, LineName = "Постановка задачи", TheMark = 5, DateOfPassing = DateTime.Now, LineIndex = 1 });
            context.CourseProjectLines.Add(new CourseProjectLine() { CourseProjectLineID = 2, RecordBookNumberID = "436002", SubjectCP_ID = 6, LineName = "Постановка задачи", TheMark = 4, DateOfPassing = DateTime.Now, LineIndex = 1 });

            context.CourseProjectLines.Add(new CourseProjectLine() { CourseProjectLineID = 3, RecordBookNumberID = "436003", SubjectCP_ID = 6, LineName = "Постановка задачи", TheMark = 4, DateOfPassing = DateTime.Now, LineIndex = 1 });
            context.CourseProjectLines.Add(new CourseProjectLine() { CourseProjectLineID = 4, RecordBookNumberID = "436004", SubjectCP_ID = 6, LineName = "Постановка задачи", TheMark = 5, DateOfPassing = DateTime.Now, LineIndex = 1 });

            context.CourseProjectLines.Add(new CourseProjectLine() { CourseProjectLineID = 5, RecordBookNumberID = "436005", SubjectCP_ID = 6, LineName = "Постановка задачи", TheMark = 5, DateOfPassing = DateTime.Now, LineIndex = 1 });
            context.CourseProjectLines.Add(new CourseProjectLine() { CourseProjectLineID = 6, RecordBookNumberID = "436006", SubjectCP_ID = 6, LineName = "Постановка задачи", TheMark = 5, DateOfPassing = DateTime.Now, LineIndex = 1 });
        }
        protected void HomeWorkInit(ref TotalJournalContextWeb context)
        {
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 1, RecordBookNumberID = "436001", HWNumber = 1, HWPoint = 11, SubjectID = 35, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 2, RecordBookNumberID = "436001", HWNumber = 1, HWPoint = 12, SubjectID = 32, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 3, RecordBookNumberID = "436001", HWNumber = 1, HWPoint = 10, SubjectID = 34, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 4, RecordBookNumberID = "436001", HWNumber = 1, HWPoint = 8, SubjectID = 33, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });

            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 5, RecordBookNumberID = "436002", HWNumber = 1, HWPoint = 10, SubjectID = 35, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 6, RecordBookNumberID = "436002", HWNumber = 1, HWPoint = 10, SubjectID = 32, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 7, RecordBookNumberID = "436002", HWNumber = 1, HWPoint = 9, SubjectID = 34, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 8, RecordBookNumberID = "436002", HWNumber = 1, HWPoint = 8, SubjectID = 33, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });

            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 9, RecordBookNumberID = "436003", HWNumber = 1, HWPoint = 7, SubjectID = 35, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 10, RecordBookNumberID = "436003", HWNumber = 1, HWPoint = 11, SubjectID = 32, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 11, RecordBookNumberID = "436003", HWNumber = 1, HWPoint = 10, SubjectID = 34, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 12, RecordBookNumberID = "436003", HWNumber = 1, HWPoint = 9, SubjectID = 33, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
        }
    }

}