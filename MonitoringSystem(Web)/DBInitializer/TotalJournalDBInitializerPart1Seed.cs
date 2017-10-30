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
        protected override void Seed(TotalJournalContextWeb context)
        {
            GroupInit(ref context);
            #region studentsInit 
            List<Student> students4 = new List<Student>
            {
                new Student() { RecordBookNumberID = "436001", FirstName = "Катерина", LastName = "Андрющенко", MiddleName = "Сергеевна", GroupID = "641п", },
                new Student() { RecordBookNumberID = "436002", FirstName = "Денис", LastName = "Билецкий", MiddleName = "Романович", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436003", FirstName = "Илья", LastName = "Вирич", MiddleName = "Васильевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436004", FirstName = "Роман", LastName = "Гайдук", MiddleName = "Валерьевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436005", FirstName = "Борис", LastName = "Головкин", MiddleName = "Анатольевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436006", FirstName = "Артур", LastName = "Гулеватый", MiddleName = "Игоревич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436007", FirstName = "Виталий", LastName = "Дворник", MiddleName = "Юрьевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436008", FirstName = "Михаил", LastName = "Дронов", MiddleName = "Эдуардович", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436009", FirstName = "Владислав", LastName = "Колесник", MiddleName = "Юрьевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436010", FirstName = "Артем", LastName = "Мирошниченко", MiddleName = "Валерьевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436011", FirstName = "Евгений", LastName = "Могилевский", MiddleName = "Романович", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436012", FirstName = "Катерина", LastName = "Плитник", MiddleName = "Витальевна", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436013", FirstName = "Вадим", LastName = "Рачков", MiddleName = "Сергеевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436014", FirstName = "Дмитрий", LastName = "Руденок", MiddleName = "Юрьевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436015", FirstName = "Оксана", LastName = "Ткаченко", MiddleName = "Витальевна", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436016", FirstName = "Артем", LastName = "Чуглазов", MiddleName = "Васильевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436017", FirstName = "Ростислав", LastName = "Шурухин", MiddleName = "Юрьевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436018", FirstName = "Александр", LastName = "Яценко", MiddleName = "Сергеевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436019", FirstName = "Евгений", LastName = "Виноградный", MiddleName = "Олегович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436020", FirstName = "Валерий", LastName = "Глянцев", MiddleName = "Олегович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436021", FirstName = "Диана", LastName = "Грушко", MiddleName = "Александровна", GroupID = "642п" },

                new Student() { RecordBookNumberID = "436022", FirstName = "Анна", LastName = "Дорошенко", MiddleName = "Сергеевна", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436023", FirstName = "Александр", LastName = "Жуган", MiddleName = "Александрович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436024", FirstName = "Александр", LastName = "Ильченко", MiddleName = "Анатольевич", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436025", FirstName = "Сергей", LastName = "Клименко", MiddleName = "Юрьевич", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436026", FirstName = "Юрий", LastName = "Кудринский", MiddleName = "Михайлович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436027", FirstName = "Александр", LastName = "Кушнарев", MiddleName = "Александрович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436028", FirstName = "Владислав", LastName = "Мокеев", MiddleName = "Олегович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436029", FirstName = "Полина", LastName = "Надеева", MiddleName = "Егоровна", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436030", FirstName = "Владислав", LastName = "Овчаренко", MiddleName = "Витальевич", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436031", FirstName = "Денис", LastName = "Пилипенко", MiddleName = "Петрович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436032", FirstName = "Владислав", LastName = "Рогинский", MiddleName = "Михайлович", GroupID = "642п" },

                new Student() { RecordBookNumberID = "436033", FirstName = "Ярослав", LastName = "Рягузов", MiddleName = "Алексеевич", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436034", FirstName = "Александр", LastName = "Силин", MiddleName = "Олегович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436035", FirstName = "Руслан", LastName = "Тибилашвли", MiddleName = "Викторович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436036", FirstName = "Андрей", LastName = "Турянский", MiddleName = "Олегович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436037", FirstName = "Богдан", LastName = "Хон", MiddleName = "Игоревич", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436038", FirstName = "Анастасия", LastName = "Чередник", MiddleName = "Юрьевна", GroupID = "642п" },

                new Student() { RecordBookNumberID = "436039", FirstName = "Олег", LastName = "Бордаков", MiddleName = "Васильевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436040", FirstName = "Александр", LastName = "Глущенко", MiddleName = "Эдуардович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436041", FirstName = "Александр", LastName = "Драшпуль", MiddleName = "Юрьевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436042", FirstName = "Анастасия", LastName = "Дучкина", MiddleName = "Михайловна", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436043", FirstName = "Виталий", LastName = "Комаровский", MiddleName = "Константинович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436044", FirstName = "Ирина", LastName = "Крайнюкова", MiddleName = "Сергеевна", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436045", FirstName = "Дмитрий", LastName = "Курдюков", MiddleName = "Семенович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436046", FirstName = "Евгения", LastName = "Ламтюгова", MiddleName = " Ильинична", GroupID = "631пст", },
                new Student() { RecordBookNumberID = "436047", FirstName = "Илья", LastName = "Олешко", MiddleName = "Сергеевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436048", FirstName = "Евгений", LastName = "Погорельцев", MiddleName = "Семенович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436049", FirstName = "Александр", LastName = "Савинков", MiddleName = "Максимович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436050", FirstName = "Александр", LastName = "Сирота", MiddleName = "Юрьевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436051", FirstName = "Ксения", LastName = "Сич", MiddleName = "Сергеевна", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436052", FirstName = "Андрей", LastName = "Телешев", MiddleName = "Александрович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436053", FirstName = "Олег", LastName = "Уманцев", MiddleName = "Сергеевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436054", FirstName = "Гриша", LastName = "Христенко", MiddleName = "Генадиевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436055", FirstName = "Сергей", LastName = "Четвернтный", MiddleName = "Олегович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436056", FirstName = "Юрий", LastName = "Шевцов", MiddleName = "Александрович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436057", FirstName = "Руслан", LastName = "Счастливый", MiddleName = "Витальевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436058", FirstName = "Роман", LastName = "Ющенко", MiddleName = "Семенович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436059", FirstName = "Ярослав", LastName = "Яскевич", MiddleName = "Витальевич", GroupID = "631пст",  }
            };
            students4.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            #endregion studentsInit
            TeacherInit(ref context);
            #region subInit
            List<Subject> subjects = new List<Subject>
            {
                new Subject() { SubjectID = 1, SubjectName = "Основы программирования", SubjectType = SubjectType.Exam, Term = 1, TeacherID=8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 2, SubjectName = "Основы программной инженерии", SubjectType = SubjectType.Exam, Term = 1, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 3, SubjectName = "Компьтерная дискретная математика", SubjectType = SubjectType.Exam, Term = 2, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 4, SubjectName = "Основы программирования", SubjectType = SubjectType.Exam, Term = 2, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 5, SubjectName = "Групповая динамика и коммуникации", SubjectType = SubjectType.Credit, Term = 2, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 6, SubjectName = "Дискретные структуры", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 7, SubjectName = "Человеко-машинное взаимодействие", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 8, SubjectName = "Объектно-ориентированное программирование", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 9, SubjectName = "Теория вероятности и математическая статистика", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 10, SubjectName = "Профессиональная практика программной инженерии", SubjectType = SubjectType.Credit, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 11, SubjectName = "Алгоритмы и структуры данных", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 12, SubjectName = "Архитектура ЭОМ", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() {}  },
                new Subject() { SubjectID = 13, SubjectName = "Эмперические методы программной инженерии", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 14, SubjectName = "Конструирование программного обеспечения", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 15, SubjectName = "Организация компьтерных сетей", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 16, SubjectName = "Объектно-ориентированное программирование", SubjectType = SubjectType.Credit, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 17, SubjectName = "Инженерная и компьютерная графика", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 18, SubjectName = "Анализ требований к программному обеспечению", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 19, SubjectName = "Операционные системы", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 20, SubjectName = "Качество ПО и тестирование", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 21, SubjectName = "Английский язык", SubjectType = SubjectType.Credit, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 22, SubjectName = "Архитектура и проектирование ПО", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 23, SubjectName = "Базы данных", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 24, SubjectName = "Методы оптимизации и исследования операций", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 25, SubjectName = "Программирование интернет", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 26, SubjectName = "Системы искусственного интелекта", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 27, SubjectName = "Android", SubjectType = SubjectType.Credit, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 28, SubjectName = "Информационные технологии разработки ПО", SubjectType = SubjectType.Exam, Term = 7, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 29, SubjectName = "Безопасность программ и данных", SubjectType = SubjectType.Exam, Term = 7, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>()},
                new Subject() { SubjectID = 30, SubjectName = "Проектирование распределенных систем ЭОМ", SubjectType = SubjectType.Exam, Term = 7, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 31, SubjectName = "Проектный практикум", SubjectType = SubjectType.Credit, Term = 7, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 32, SubjectName = "Менеджмент проектов ПО", SubjectType = SubjectType.Exam, Term = 8, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 33, SubjectName = "Проектирование производственных экспертных систем", SubjectType = SubjectType.Exam, Term = 8, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 34, SubjectName = "Международные стандарты программной инженерии", SubjectType = SubjectType.Exam, Term = 8, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 35, SubjectName = "Проектный практикум", SubjectType = SubjectType.Credit, Term = 8, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>()}
            };
            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();
            #endregion subInit
            foreach (var subject in context.Subjects)
            {
                foreach (var group in context.Groups)
                {
                    if (subject.Term == 7 || subject.Term == 8)
                    {
                        if (group.CourseNumber == 4)
                        {
                            subject.Groups.Add(group);
                        }
                    }
                    if (subject.Term == 5 || subject.Term == 6)
                    {
                        if (group.CourseNumber == 3)
                        {
                            subject.Groups.Add(group);
                        }
                    }
                    if (subject.Term == 3 || subject.Term == 4)
                    {
                        if (group.CourseNumber == 2)
                        {
                            subject.Groups.Add(group);
                        }
                    }
                    if (subject.Term == 1 || subject.Term == 2)
                    {
                        if (group.CourseNumber == 1)
                        {
                            subject.Groups.Add(group);
                        }
                    }
                }
            }
            context.SaveChanges();

            List<SubjectCP> subjectCPs = new List<SubjectCP>()
            {
                new SubjectCP() { SubjectCP_ID = 1, SubjectCPName = "Основы программирования(КП)", Term = 3, TeacherID = 1, Groups = new List<Group>() },
                new SubjectCP() { SubjectCP_ID = 2, SubjectCPName = "Объектно-ориентированное программирование(КП)", Term = 4, TeacherID = 1, Groups = new List<Group>() },
                new SubjectCP() { SubjectCP_ID = 3, SubjectCPName = "Алгоритмы и структуры данных(КП)", Term = 5, TeacherID = 1, Groups = new List<Group>() },
                new SubjectCP() { SubjectCP_ID = 4, SubjectCPName = "Операционные системы(КП)", Term = 6, TeacherID = 1, Groups = new List<Group>() },
                new SubjectCP() { SubjectCP_ID = 5, SubjectCPName = "Базы данных(КП)", Term = 7, TeacherID = 1 , Groups = new List<Group>()},
                new SubjectCP() { SubjectCP_ID = 6, SubjectCPName = "Проектирование распределенных систем ЭВМ(КП)", Term = 8, TeacherID = 1, Groups = new List<Group>() }
            };
            subjectCPs.ForEach(s => context.SubjectCPs.Add(s));
            context.SaveChanges();
            foreach (var subjectCP in context.SubjectCPs)
            {
                foreach (var group in context.Groups)
                {
                    if (subjectCP.Term == 7 || subjectCP.Term == 8)
                    {
                        if (group.CourseNumber == 4)
                        {
                            subjectCP.Groups.Add(group);
                        }
                    }
                    if (subjectCP.Term == 5 || subjectCP.Term == 6)
                    {
                        if (group.CourseNumber == 3)
                        {
                            subjectCP.Groups.Add(group);
                        }
                    }
                    if (subjectCP.Term == 3 || subjectCP.Term == 4)
                    {
                        if (group.CourseNumber == 2)
                        {
                            subjectCP.Groups.Add(group);
                        }
                    }
                    if (subjectCP.Term == 1 || subjectCP.Term == 2)
                    {
                        if (group.CourseNumber == 1)
                        {
                            subjectCP.Groups.Add(group);
                        }
                    }
                }
            }
            context.SaveChanges();

            //MarkInit(ref context);
            //SubjectCPInit(ref context);
            //CourseProjectLineInit(ref context);
            //ModuleInit(ref context);
            //HomeWorkInit(ref context);
            //AttendanceInit(ref context);

            //context.LabMaxPoints.Add(new LabMaxPoint() { LabMaxPointID = 1, LabNumber = 1, MaxPoint = 5, SubjectID = 32 });
            //context.LabMaxPoints.Add(new LabMaxPoint() { LabMaxPointID = 2, LabNumber = 2, MaxPoint = 5, SubjectID = 32 });
            //context.LabMaxPoints.Add(new LabMaxPoint() { LabMaxPointID = 3, LabNumber = 3, MaxPoint = 5, SubjectID = 32 });
            //context.HWMaxPoints.Add(new HWMaxPoint() { HWMaxPointID = 1, HWNumber = 1, MaxPoint = 15, SubjectID = 32 });
            //context.ModuleMaxPoints.Add(new ModuleMaxPoint() { ModuleMaxPointID = 3, ModuleNumber = 1, MaxPoint = 20, SubjectID = 32 });

            //context.AttMaxPoints.Add(new AttMaxPoint() { AttMaxPointID = 1, MaxAmount = 0, SubjectID = 32 });

            //context.FreeMarkFields.Add(new FreeMarkField() { FreeMarkFieldID = 1, FieldName = "Доп.баллы", FieldNumber = 1, FieldPoint = 5, RecordBookNumberID = "436001", SubjectID = 32 });
            //context.FreeMarkFields.Add(new FreeMarkField() { FreeMarkFieldID = 2, FieldName = "Доп.баллы", FieldNumber = 1, FieldPoint = 5, RecordBookNumberID = "436002", SubjectID = 32 });
            //context.FreeMarkFields.Add(new FreeMarkField() { FreeMarkFieldID = 3, FieldName = "Доп.баллы", FieldNumber = 1, FieldPoint = 5, RecordBookNumberID = "436003", SubjectID = 32 });
            //context.FreeMarkFieldMaxPoints.Add(new FreeMarkFieldMaxPoint() { FreeMarkFieldMaxPointID = 1, FieldName = "Доп.баллы", MaxPoint = 10, FieldNumber = 1, SubjectID = 32 });

            //context.CPLineMaxPoints.Add(new CPLineMaxPoint() { CPLineMaxPointID = 1, LineIndex = 1, LineName = "Постановка задачи", MaxPoint = 5, SubjectCPID = 6 });
            context.OneItemPoints.Add(new OneItemPoint() { OneItemPointID = 1, SubjectId = 32, Value = "1" });

            context.SaveChanges();
            base.Seed(context);
        }
    }

}