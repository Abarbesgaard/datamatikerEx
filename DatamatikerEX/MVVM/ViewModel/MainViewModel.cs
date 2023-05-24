using DatamatikerEX.Core;
using DatamatikerEX.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatamatikerEX.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ExerciseModel> Exercises { get; set; }

        private ExerciseModel _selectedExercise;

        public ExerciseModel SelectedExercise
        {
            get { return _selectedExercise; }
            set
            {
                _selectedExercise = value;
                OnPropertyChanged(Message);
            }
        }


        private string _message;

        public string Message
        {
            get { return _message; }

            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            var Messages = new ObservableCollection<MessageModel>();

            var MessagesOpgave2 = new ObservableCollection<MessageModel>();

            Exercises = new ObservableCollection<ExerciseModel>();


            Messages.Add(new MessageModel
            {
                ExerciseNumber = "1",
                ExerciseName = "Øvelse 1",
                ExerciseSubtitle = "Terminologi"


            });
            Messages.Add(new MessageModel
            {
                ExerciseNumber = "1.1",
                Message = "Del teamet op i mindre grupper (af 2 personer), og brug Ordet rundt til at reflektere over begreberne \n”navnekonventioner (en: naming conventions)”,\n”test initialize”,\n”this keyword” og \n”namespaces”.\nSørg for, at alle får mulighed for at tale.",
                TimeFrame = "20 minutter"
            });

            Messages.Add(new MessageModel
            {
                ExerciseNumber = "2",
                ExerciseName = "Øvelse 2",
                ExerciseSubtitle = "Orange Tree Simulation",
            });

            Messages.Add(new MessageModel
            {
                ExerciseNumber = "2.1",
                ExerciseName = "Øvelse 2",
                ExerciseSubtitle = "Orange Tree Simulation",
                Message = "De første øvelser forneden omfatter oprettelse af konsolprojekt, testprojekt og implementering af den centrale \nC#-klasse, OrangeTree, til simulering af et appelsintræs livsforløb. \nDen sidste øvelse er selve gennemførelse af en unit-test for at tjekke, om din implemente¬ring er korrekt. \nNår du kører testen i Test Explorer, retter du i din implementering, indtil alle tests kører uden problemer (dvs. er grønne). Det forklares nærmere, når du kommer til øvelsen.",
                TimeFrame = "20 minutter"
                
            });

            Messages.Add(new MessageModel
            {
                Message = "De første øvelser forneden omfatter oprettelse af konsolprojekt, testprojekt og implementering af den centrale \nC#-klasse, OrangeTree, til simulering af et appelsintræs livsforløb. \nDen sidste øvelse er selve gennemførelse af en unit-test for at tjekke, om din implemente¬ring er korrekt. \nNår du kører testen i Test Explorer, retter du i din implementering, indtil alle tests kører uden problemer (dvs. er grønne). Det forklares nærmere, når du kommer til øvelsen."
            });

            MessagesOpgave2.Add(new MessageModel
            {
                ExerciseName = "Øvelse 1",
                ExerciseSubtitle = "Terminologi",

            });

            MessagesOpgave2.Add(new MessageModel
            {
                Message = "SOOOOOOOOOOOOOOOOOOOOOOOOOOOOVS"
            });



            Exercises.Add(new ExerciseModel
            {

                ExerciseName = "Opgave 1",
                ExerciseDescription = "Tusindfryd",
                Messages = Messages
            });
            Exercises.Add(new ExerciseModel
            {
                ExerciseName = "Opgave 2",
                ExerciseDescription = "Disaheim",
                Messages = MessagesOpgave2

            });

            Exercises.Add(new ExerciseModel
            {
                ExerciseName = "Opgave 3",
                ExerciseDescription = "dette er opgave ex3",
                Messages = Messages

            });
            Exercises.Add(new ExerciseModel
            {
                ExerciseName = "Opgave 4",
                ExerciseDescription = "dette er opgave ex4",
                Messages = Messages

            });

        }
    }
}
