namespace DataLibrary.Extensions
{
    public static class Enums
    {
        public enum ActivityType
        {
            ComputerGame,
            BoardGame,
            Learning,
            Other,
            GroupActivity
        }

        public enum PartType
        {
            Case,
            CPU,
            HardDrive,
            Mainboard,
            Monitor,
            PowerSupply,
            RAM,
            SolidStateDrive,
            VideoCard,
            Other
        }

        public enum FormFactor
        {
            Laptop,
            Desktop,
            Tower,
            Micro,
            RackMount,
            Server
        }

        public enum DriveType
        {
            Mechanical,
            SSD,
            NVMe
        }

        public enum IncidentType
        {
            AgressiveBehaviour = 1,
            DisobeyInstructions = 2,
            InappropriateLanguage = 3,
            Meltdown = 4,
            DisruptiveBehaviour = 5,
            NonCoOperativeBehaviour = 6
        }

        public enum ExpectationType
        {
            Parent = 1,
            Member = 2
        }

        public enum SessionType
        {
            Morning = 1,
            Noon = 2,
            All = 3
        }
    }
}