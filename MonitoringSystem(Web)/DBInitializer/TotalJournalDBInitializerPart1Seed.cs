using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonitoringSystemModel;
using System.Data.Entity;

namespace MonitoringSystem_Web_.DBInitializer
{
    public partial class TotalJournalDBInitializer 
    {
        protected override void Seed(TotalJournalContextWeb context)
        {
            ClassInit(ref context);
            #region schoolkidsInit 
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
            List<Subject> subjects = new List<Subject>
            {
                new Subject() { SubjectID = 1,  SubjectName = "Основы программирования", TeacherID=8, Classes = new List<Class>() },
                new Subject() { SubjectID = 2,  SubjectName = "Основы программной инженерии", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 3,  SubjectName = "Компьтерная дискретная математика", TeacherID = 8,  Classes = new List<Class>() },
                new Subject() { SubjectID = 4,  SubjectName = "Основы программирования",  TeacherID = 8, Classes = new List<Class>() },
                new Subject() { SubjectID = 5,  SubjectName = "Групповая динамика и коммуникации",  TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 6,  SubjectName = "Дискретные структуры", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 7,  SubjectName = "Человеко-машинное взаимодействие",  TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 8,  SubjectName = "Объектно-ориентированное программирование",  TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 9,  SubjectName = "Теория вероятности и математическая статистика",  TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 10, SubjectName = "Профессиональная практика программной инженерии",  TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 11, SubjectName = "Алгоритмы и структуры данных",  TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 12, SubjectName = "Архитектура ЭОМ",  TeacherID = 8,   Classes = new List<Class>() {}  },
                new Subject() { SubjectID = 13, SubjectName = "Эмперические методы программной инженерии", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 14, SubjectName = "Конструирование программного обеспечения", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 15, SubjectName = "Организация компьтерных сетей",  TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 16, SubjectName = "Объектно-ориентированное программирование", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 17, SubjectName = "Инженерная и компьютерная графика",  TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 18, SubjectName = "Анализ требований к программному обеспечению", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 19, SubjectName = "Операционные системы", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 20, SubjectName = "Качество ПО и тестирование", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 21, SubjectName = "Английский язык", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 22, SubjectName = "Архитектура и проектирование ПО",  TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 23, SubjectName = "Базы данных", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 24, SubjectName = "Методы оптимизации и исследования операций",  TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 25, SubjectName = "Программирование интернет",  TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 26, SubjectName = "Системы искусственного интелекта", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 27, SubjectName = "Android", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 28, SubjectName = "Информационные технологии разработки ПО", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 29, SubjectName = "Безопасность программ и данных", TeacherID = 8,   Classes = new List<Class>()},
                new Subject() { SubjectID = 30, SubjectName = "Проектирование распределенных систем ЭОМ", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 31, SubjectName = "Проектный практикум",  TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 32, SubjectName = "Менеджмент проектов ПО", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 33, SubjectName = "Проектирование производственных экспертных систем", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 34, SubjectName = "Международные стандарты программной инженерии", TeacherID = 8,   Classes = new List<Class>() },
                new Subject() { SubjectID = 35, SubjectName = "Проектный практикум", TeacherID = 8,   Classes = new List<Class>()}
            };
            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();
            #endregion subInit
            Class @class = context.Classes.Find("1");
            for (int i = 0; i < 5; i++)
            {
                context.Subjects.ToArray()[i].Classes.Add(@class);
            }

            @class = context.Classes.Find("2");
            for (int i = 5; i < 10; i++)
            {
                context.Subjects.ToArray()[i].Classes.Add(@class);
            }

            @class = context.Classes.Find("3");
            for (int i = 10; i < 15; i++)
            {
                context.Subjects.ToArray()[i].Classes.Add(@class);
            }

            @class = context.Classes.Find("4");
            for (int i = 15; i < 20; i++)
            {
                context.Subjects.ToArray()[i].Classes.Add(@class);
            }

            @class = context.Classes.Find("5");
            for (int i = 20; i < 25; i++)
            {
                context.Subjects.ToArray()[i].Classes.Add(@class);
            }            
            context.SaveChanges();

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