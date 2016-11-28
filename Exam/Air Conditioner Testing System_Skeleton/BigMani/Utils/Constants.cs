﻿namespace ACTS.Utils
{
    public static class Constants
    {
        public const string IncorrectPropertyLength = "{0}'s name must be at least {1} symbols long.";

        public const string NoReports = "No reports.";

        public const string InvalidCommand = "Invalid command";

        public const string StatusMessage = "Jobs complete: {0:F2}%";

        public const string IncorrectRatingMessage = "Energy efficiency rating must be between \"A\" and \"E\".";

        public const string NonPositiveMessage = "{0} must be a positive integer.";

        public const string DuplicateEntryMessage = "An entry for the given model already exists.";

        public const string NonExistantEntryMessage = "The specified entry does not exist.";

        public const string RegisterMessage = "Air Conditioner model {0} from {1} registered successfully.";

        public const string TestMessage = 
            "Air Conditioner model {1} from {0} tested successfully."; // BUG: placeholders were swapped - FIXED

        public const int ModelMinLength = 2; // BUG: value was 1 - FIXED

        public const int ManufacturerMinLength = 4;

        public const int MinCarVolume = 3;

        public const int MinPlaneElectricity = 150;

        public static readonly string Border = new string('=', 20);
    }
}