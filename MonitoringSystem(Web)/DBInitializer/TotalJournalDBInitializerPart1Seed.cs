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
            ClassInit(ref context);
            #region studentsInit 
            List<SchoolKid> schoolKids = new List<SchoolKid>
            {
                new SchoolKid() { SchoolKidId = 1, FirstName = "Катерина", LastName = "Андрющенко", MiddleName = "Сергеевна", ClassID = "1", },
                new SchoolKid() { SchoolKidId = 2, FirstName = "Денис", LastName = "Билецкий", MiddleName = "Романович", ClassID = "1" },
                new SchoolKid() { SchoolKidId = 3, FirstName = "Илья", LastName = "Вирич", MiddleName = "Васильевич", ClassID = "1" },
                new SchoolKid() { SchoolKidId = 4, FirstName = "Роман", LastName = "Гайдук", MiddleName = "Валерьевич", ClassID = "1" },
                new SchoolKid() { SchoolKidId = 5, FirstName = "Борис", LastName = "Головкин", MiddleName = "Анатольевич", ClassID = "1" },
                new SchoolKid() { SchoolKidId = 6, FirstName = "Артур", LastName = "Гулеватый", MiddleName = "Игоревич", ClassID = "1" },
                new SchoolKid() { SchoolKidId = 7, FirstName = "Виталий", LastName = "Дворник", MiddleName = "Юрьевич", ClassID = "1" },
                new SchoolKid() { SchoolKidId = 8, FirstName = "Михаил", LastName = "Дронов", MiddleName = "Эдуардович", ClassID = "1" },
                new SchoolKid() { SchoolKidId = 9, FirstName = "Владислав", LastName = "Колесник", MiddleName = "Юрьевич", ClassID = "1" },
                new SchoolKid() { SchoolKidId = 10, FirstName = "Артем", LastName = "Мирошниченко", MiddleName = "Валерьевич", ClassID = "1" },

                new SchoolKid() { SchoolKidId = 11, FirstName = "Евгений", LastName = "Могилевский", MiddleName = "Романович", ClassID = "2" },
                new SchoolKid() { SchoolKidId = 12, FirstName = "Катерина", LastName = "Плитник", MiddleName = "Витальевна", ClassID = "2" },
                new SchoolKid() { SchoolKidId = 13, FirstName = "Вадим", LastName = "Рачков", MiddleName = "Сергеевич", ClassID = "2" },
                new SchoolKid() { SchoolKidId = 14, FirstName = "Дмитрий", LastName = "Руденок", MiddleName = "Юрьевич", ClassID = "2" },
                new SchoolKid() { SchoolKidId = 15, FirstName = "Оксана", LastName = "Ткаченко", MiddleName = "Витальевна", ClassID = "2" },
                new SchoolKid() { SchoolKidId = 16, FirstName = "Артем", LastName = "Чуглазов", MiddleName = "Васильевич", ClassID = "2" },
                new SchoolKid() { SchoolKidId = 17, FirstName = "Ростислав", LastName = "Шурухин", MiddleName = "Юрьевич", ClassID = "2" },
                new SchoolKid() { SchoolKidId = 18, FirstName = "Александр", LastName = "Яценко", MiddleName = "Сергеевич", ClassID = "2" },
                new SchoolKid() { SchoolKidId = 19, FirstName = "Евгений", LastName = "Виноградный", MiddleName = "Олегович", ClassID = "2" },
                new SchoolKid() { SchoolKidId = 20, FirstName = "Валерий", LastName = "Глянцев", MiddleName = "Олегович", ClassID = "2" },

                new SchoolKid() { SchoolKidId = 21, FirstName = "Диана", LastName = "Грушко", MiddleName = "Александровна", ClassID = "3" },
                new SchoolKid() { SchoolKidId = 22, FirstName = "Анна", LastName = "Дорошенко", MiddleName = "Сергеевна", ClassID = "3" },
                new SchoolKid() { SchoolKidId = 23, FirstName = "Александр", LastName = "Жуган", MiddleName = "Александрович", ClassID = "3" },
                new SchoolKid() { SchoolKidId = 24, FirstName = "Александр", LastName = "Ильченко", MiddleName = "Анатольевич", ClassID = "3" },
                new SchoolKid() { SchoolKidId = 25, FirstName = "Сергей", LastName = "Клименко", MiddleName = "Юрьевич", ClassID = "3" },
                new SchoolKid() { SchoolKidId = 26, FirstName = "Юрий", LastName = "Кудринский", MiddleName = "Михайлович", ClassID = "3" },
                new SchoolKid() { SchoolKidId = 27, FirstName = "Александр", LastName = "Кушнарев", MiddleName = "Александрович", ClassID = "3" },
                new SchoolKid() { SchoolKidId = 28, FirstName = "Владислав", LastName = "Мокеев", MiddleName = "Олегович", ClassID = "3" },
                new SchoolKid() { SchoolKidId = 29, FirstName = "Полина", LastName = "Надеева", MiddleName = "Егоровна", ClassID = "3" },
                new SchoolKid() { SchoolKidId = 30, FirstName = "Владислав", LastName = "Овчаренко", MiddleName = "Витальевич", ClassID = "3" },

                new SchoolKid() { SchoolKidId = 31, FirstName = "Денис", LastName = "Пилипенко", MiddleName = "Петрович", ClassID = "9" },
                new SchoolKid() { SchoolKidId = 32, FirstName = "Владислав", LastName = "Рогинский", MiddleName = "Михайлович", ClassID = "9" },
                new SchoolKid() { SchoolKidId = 33, FirstName = "Ярослав", LastName = "Рягузов", MiddleName = "Алексеевич", ClassID = "9" },
                new SchoolKid() { SchoolKidId = 34, FirstName = "Александр", LastName = "Силин", MiddleName = "Олегович", ClassID = "9" },
                new SchoolKid() { SchoolKidId = 35, FirstName = "Руслан", LastName = "Тибилашвли", MiddleName = "Викторович", ClassID = "9" },
                new SchoolKid() { SchoolKidId = 36, FirstName = "Андрей", LastName = "Турянский", MiddleName = "Олегович", ClassID = "9" },
                new SchoolKid() { SchoolKidId = 37, FirstName = "Богдан", LastName = "Хон", MiddleName = "Игоревич", ClassID = "9" },
                new SchoolKid() { SchoolKidId = 38, FirstName = "Анастасия", LastName = "Чередник", MiddleName = "Юрьевна", ClassID = "9" },
                new SchoolKid() { SchoolKidId = 39, FirstName = "Олег", LastName = "Бордаков", MiddleName = "Васильевич", ClassID = "9" },
                new SchoolKid() { SchoolKidId = 40, FirstName = "Александр", LastName = "Глущенко", MiddleName = "Эдуардович", ClassID = "9" },

                new SchoolKid() { SchoolKidId = 41, FirstName = "Александр", LastName = "Драшпуль", MiddleName = "Юрьевич", ClassID = "10" },
                new SchoolKid() { SchoolKidId = 42, FirstName = "Анастасия", LastName = "Дучкина", MiddleName = "Михайловна", ClassID = "10" },
                new SchoolKid() { SchoolKidId = 43, FirstName = "Виталий", LastName = "Комаровский", MiddleName = "Константинович", ClassID = "10" },
                new SchoolKid() { SchoolKidId = 44, FirstName = "Ирина", LastName = "Крайнюкова", MiddleName = "Сергеевна", ClassID = "10" },
                new SchoolKid() { SchoolKidId = 45, FirstName = "Дмитрий", LastName = "Курдюков", MiddleName = "Семенович", ClassID = "10" },
                new SchoolKid() { SchoolKidId = 46, FirstName = "Евгения", LastName = "Ламтюгова", MiddleName = " Ильинична", ClassID = "10", },
                new SchoolKid() { SchoolKidId = 47, FirstName = "Илья", LastName = "Олешко", MiddleName = "Сергеевич", ClassID = "10" },
                new SchoolKid() { SchoolKidId = 48, FirstName = "Евгений", LastName = "Погорельцев", MiddleName = "Семенович", ClassID = "10" },
                new SchoolKid() { SchoolKidId = 49, FirstName = "Александр", LastName = "Савинков", MiddleName = "Максимович", ClassID = "10" },
                new SchoolKid() { SchoolKidId = 50, FirstName = "Александр", LastName = "Сирота", MiddleName = "Юрьевич", ClassID = "10" },

                new SchoolKid() { SchoolKidId = 51, FirstName = "Ксения", LastName = "Сич", MiddleName = "Сергеевна", ClassID = "11" },
                new SchoolKid() { SchoolKidId = 52, FirstName = "Андрей", LastName = "Телешев", MiddleName = "Александрович", ClassID = "11" },
                new SchoolKid() { SchoolKidId = 53, FirstName = "Олег", LastName = "Уманцев", MiddleName = "Сергеевич", ClassID = "11" },
                new SchoolKid() { SchoolKidId = 54, FirstName = "Гриша", LastName = "Христенко", MiddleName = "Генадиевич", ClassID = "11" },
                new SchoolKid() { SchoolKidId = 55, FirstName = "Сергей", LastName = "Четвернтный", MiddleName = "Олегович", ClassID = "11" },
                new SchoolKid() { SchoolKidId = 56, FirstName = "Юрий", LastName = "Шевцов", MiddleName = "Александрович", ClassID = "11" },
                new SchoolKid() { SchoolKidId = 57, FirstName = "Руслан", LastName = "Счастливый", MiddleName = "Витальевич", ClassID = "11" },
                new SchoolKid() { SchoolKidId = 58, FirstName = "Роман", LastName = "Ющенко", MiddleName = "Семенович", ClassID = "11" },
                new SchoolKid() { SchoolKidId = 59, FirstName = "Ярослав", LastName = "Яскевич", MiddleName = "Витальевич", ClassID = "11",  }
            };
            schoolKids.ForEach(s => context.SchoolKids.Add(s));
            context.SaveChanges();
            #endregion studentsInit
            TeacherInit(ref context);
            #region subInit
            List<SubjectCP> subjects = new List<SubjectCP>
            {
                new SubjectCP() { SubjectCP_ID = 1, SubjectCPName = "Основы программирования", TeacherID=8, Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 2, SubjectCPName = "Основы программной инженерии", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 3, SubjectCPName = "Компьтерная дискретная математика", TeacherID = 8,  Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 4, SubjectCPName = "Основы программирования",  TeacherID = 8, Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 5, SubjectCPName = "Групповая динамика и коммуникации",  TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 6, SubjectCPName = "Дискретные структуры", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 7, SubjectCPName = "Человеко-машинное взаимодействие",  TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 8, SubjectCPName = "Объектно-ориентированное программирование",  TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 9, SubjectCPName = "Теория вероятности и математическая статистика",  TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 10, SubjectCPName = "Профессиональная практика программной инженерии",  TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 11, SubjectCPName = "Алгоритмы и структуры данных",  TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 12, SubjectCPName = "Архитектура ЭОМ",  TeacherID = 8,   Classes = new List<Class>() {}  },
                new SubjectCP() { SubjectCP_ID = 13, SubjectCPName = "Эмперические методы программной инженерии", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 14, SubjectCPName = "Конструирование программного обеспечения", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 15, SubjectCPName = "Организация компьтерных сетей",  TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 16, SubjectCPName = "Объектно-ориентированное программирование", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 17, SubjectCPName = "Инженерная и компьютерная графика",  TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 18, SubjectCPName = "Анализ требований к программному обеспечению", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 19, SubjectCPName = "Операционные системы", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 20, SubjectCPName = "Качество ПО и тестирование", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 21, SubjectCPName = "Английский язык", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 22, SubjectCPName = "Архитектура и проектирование ПО",  TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 23, SubjectCPName = "Базы данных", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 24, SubjectCPName = "Методы оптимизации и исследования операций",  TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 25, SubjectCPName = "Программирование интернет",  TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 26, SubjectCPName = "Системы искусственного интелекта", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 27, SubjectCPName = "Android", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 28, SubjectCPName = "Информационные технологии разработки ПО", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 29, SubjectCPName = "Безопасность программ и данных", TeacherID = 8,   Classes = new List<Class>()},
                new SubjectCP() { SubjectCP_ID = 30, SubjectCPName = "Проектирование распределенных систем ЭОМ", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 31, SubjectCPName = "Проектный практикум",  TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 32, SubjectCPName = "Менеджмент проектов ПО", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 33, SubjectCPName = "Проектирование производственных экспертных систем", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 34, SubjectCPName = "Международные стандарты программной инженерии", TeacherID = 8,   Classes = new List<Class>() },
                new SubjectCP() { SubjectCP_ID = 35, SubjectCPName = "Проектный практикум", TeacherID = 8,   Classes = new List<Class>()}
            };
            subjects.ForEach(s => context.SubjectCPs.Add(s));
            context.SaveChanges();
            #endregion subInit
            //foreach (var subject in context.Subjects)
            //{
            //    foreach (var group in context.Classes)
            //    {
            //        if (subject.Term == 7 || subject.Term == 8)
            //        {
            //            if (group.CourseNumber == 4)
            //            {
            //                subject.Classes.Add(group);
            //            }
            //        }
            //        if (subject.Term == 5 || subject.Term == 6)
            //        {
            //            if (group.CourseNumber == 3)
            //            {
            //                subject.Classes.Add(group);
            //            }
            //        }
            //        if (subject.Term == 3 || subject.Term == 4)
            //        {
            //            if (group.CourseNumber == 2)
            //            {
            //                subject.Classes.Add(group);
            //            }
            //        }
            //        if (subject.Term == 1 || subject.Term == 2)
            //        {
            //            if (group.CourseNumber == 1)
            //            {
            //                subject.Classes.Add(group);
            //            }
            //        }
            //    }
            //}
            //context.SaveChanges();

            //List<SubjectCP> subjectCPs = new List<SubjectCP>()
            //{
            //    new SubjectCP() { SubjectCP_ID = 1, SubjectCPName = "Основы программирования(КП)", Term = 3, TeacherID = 1, Classes = new List<Class>() },
            //    new SubjectCP() { SubjectCP_ID = 2, SubjectCPName = "Объектно-ориентированное программирование(КП)", Term = 4, TeacherID = 1, Classes = new List<Class>() },
            //    new SubjectCP() { SubjectCP_ID = 3, SubjectCPName = "Алгоритмы и структуры данных(КП)", Term = 5, TeacherID = 1, Classes = new List<Class>() },
            //    new SubjectCP() { SubjectCP_ID = 4, SubjectCPName = "Операционные системы(КП)", Term = 6, TeacherID = 1, Classes = new List<Class>() },
            //    new SubjectCP() { SubjectCP_ID = 5, SubjectCPName = "Базы данных(КП)", Term = 7, TeacherID = 1 , Classes = new List<Class>()},
            //    new SubjectCP() { SubjectCP_ID = 6, SubjectCPName = "Проектирование распределенных систем ЭВМ(КП)", Term = 8, TeacherID = 1, Classes = new List<Class>() }
            //};
            //subjectCPs.ForEach(s => context.SubjectCPs.Add(s));
            //context.SaveChanges();
            //foreach (var subjectCP in context.SubjectCPs)
            //{
            //    foreach (var group in context.Classes)
            //    {
            //        if (subjectCP.Term == 7 || subjectCP.Term == 8)
            //        {
            //            if (group.CourseNumber == 4)
            //            {
            //                subjectCP.Classes.Add(group);
            //            }
            //        }
            //        if (subjectCP.Term == 5 || subjectCP.Term == 6)
            //        {
            //            if (group.CourseNumber == 3)
            //            {
            //                subjectCP.Classes.Add(group);
            //            }
            //        }
            //        if (subjectCP.Term == 3 || subjectCP.Term == 4)
            //        {
            //            if (group.CourseNumber == 2)
            //            {
            //                subjectCP.Classes.Add(group);
            //            }
            //        }
            //        if (subjectCP.Term == 1 || subjectCP.Term == 2)
            //        {
            //            if (group.CourseNumber == 1)
            //            {
            //                subjectCP.Classes.Add(group);
            //            }
            //        }
            //    }
            //}
            //context.SaveChanges();

            //MarkInit(ref context);
            //SubjectCPInit(ref context);
            //CourseProjectLineInit(ref context);
            //ModuleInit(ref context);
            //HomeWorkInit(ref context);
            ////AttendanceInit(ref context);

            //context.LabMaxPoints.Add(new LabMaxPoint() { LabMaxPointID = 1, LabNumber = 1, MaxPoint = 5, SubjectCP_ID = 32 });
            //context.LabMaxPoints.Add(new LabMaxPoint() { LabMaxPointID = 2, LabNumber = 2, MaxPoint = 5, SubjectCP_ID = 32 });
            //context.LabMaxPoints.Add(new LabMaxPoint() { LabMaxPointID = 3, LabNumber = 3, MaxPoint = 5, SubjectCP_ID = 32 });
            //context.HWMaxPoints.Add(new HWMaxPoint() { HWMaxPointID = 1, HWNumber = 1, MaxPoint = 15, SubjectCP_ID = 32 });
            //context.ModuleMaxPoints.Add(new ModuleMaxPoint() { ModuleMaxPointID = 3, ModuleNumber = 1, MaxPoint = 20, SubjectCP_ID = 32 });

            ////context.AttMaxPoints.Add(new AttMaxPoint() { AttMaxPointID = 1, MaxAmount = 0, SubjectCP_ID = 32 });

            //context.FreeMarkFields.Add(new FreeMarkField() { FreeMarkFieldID = 1, FieldName = "Доп.баллы", FieldNumber = 1, FieldPoint = 5, RecordBookNumberID = "436001", SubjectCP_ID = 32 });
            //context.FreeMarkFields.Add(new FreeMarkField() { FreeMarkFieldID = 2, FieldName = "Доп.баллы", FieldNumber = 1, FieldPoint = 5, RecordBookNumberID = "436002", SubjectCP_ID = 32 });
            //context.FreeMarkFields.Add(new FreeMarkField() { FreeMarkFieldID = 3, FieldName = "Доп.баллы", FieldNumber = 1, FieldPoint = 5, RecordBookNumberID = "436003", SubjectCP_ID = 32 });
            //context.FreeMarkFieldMaxPoints.Add(new FreeMarkFieldMaxPoint() { FreeMarkFieldMaxPointID = 1, FieldName = "Доп.баллы", MaxPoint = 10, FieldNumber = 1, SubjectCP_ID = 32 });

            //context.CPLineMaxPoints.Add(new CPLineMaxPoint() { CPLineMaxPointID = 1, LineIndex = 1, LineName = "Постановка задачи", MaxPoint = 5, SubjectCPID = 6 });
            //context.OneItemPoints.Add(new OneItemPoint() { OneItemPointID = 1, SubjectId = 32, Value = "1" });

            context.SaveChanges();
            base.Seed(context);
        }
    }

}