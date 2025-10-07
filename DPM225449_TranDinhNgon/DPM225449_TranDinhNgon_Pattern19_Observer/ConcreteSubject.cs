namespace Observer.Structural
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    public class ConcreteSubject : Subject
    {
        private string subjectState;

        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}