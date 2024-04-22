namespace InheritanceCategories.V3
{
    public class Status
    {
        public const string NotStarted = "not started";
        public const string InProgress = "in progress";
        public const string Done = "done";

        public void Display() { }
        public void Change() { }
    }

    public class Test : Status
    {
        public const string InTest = "in test";
    }
}