using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamatikerEX.MVVM.Model
{
    public class ExerciseModel
    {
        public string ExerciseName { get; set; }
        public string ExerciseSubtitle { get; set; }
        public string ExerciseDescription { get; set; }
        public string ImageSource { get; set; }

        public ObservableCollection<MessageModel> Messages { get; set; }
    
    }
}
