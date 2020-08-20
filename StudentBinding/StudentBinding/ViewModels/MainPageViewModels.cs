using StudentBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBinding.ViewModels
{
    class MainPageViewModels
    {
        public ObservableCollection<Models.Student> ListStudents { get; private set; }
            = new ObservableCollection<Models.Student>();
        public MainPageViewModels()
        {
            ListStudents.Add(new Models.Student()
            {
                Id = "AA001",
                Name = "Hoang Long",
                Gpa = 8.5f,
            });
            ListStudents.Add(new Models.Student()
            {
                Id = "AA002",
                Name = "Hoang Anh",
                Gpa = 8.0f,
            });
            ListStudents.Add(new Models.Student()
            {
                Id = "AA003",
                Name = "Hoang Lam",
                Gpa = 7.0f,
            });
        }
    }
}
