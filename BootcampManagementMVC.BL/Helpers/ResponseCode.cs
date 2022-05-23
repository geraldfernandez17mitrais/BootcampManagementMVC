namespace BootcampManagementMVC.BL.Helpers
{
    public static class ResponseCode
    {
        // BootcampGroup:
        public const string bootcampGroupInvalidId = "Bootcamp's Id is invalid.";
        public const string bootcampGroupAlreadyExist = "Bootcamp already exist.";
        public const string bootcampGroupNotFound = "Bootcamp not found.";
        public const string bootcampGroupCannotBeChangedToInactive = "Bootcamp can't be changed to inactive since any member is still joining.";

        // Stage:
        public const string stageInvalidId = "Stage's Id is invalid.";
        public const string stageNotFound = "Stage not found.";
        public const string stageAlreadyExist = "Stage already exist.";
        public const string stageWasUsed = "Stage was used on Syllabus Task.";

        // Syllabus:
        public const string syllabusInvalidId = "Syllabus's Id is invalid.";
        public const string syllabusNotFound = "Syllabus not found.";

        // SyllabusTask:
        public const string syllabusTaskInvalidId = "Syllabus task's Id is invalid.";
        public const string syllabusTaskAlreadyExist = "Syllabus task already exist.";
        public const string syllabusTaskNotFound = "Syllabus task not found.";

        // Request:
        public const string requestInvalidId = "Request's Id is invalid.";
        public const string requestInactiveBootcampFailed = "Enroll can not be processed because bootcamp is inactive.";
        public const string requestNotFound = "Request not found.";
        public const string requestRejectFailedBecauseEmptyMessage = "Please fill the message as the rejection's reason.";
        public const string requestDuplication = "Enroll can not be processed because the same data has been existed.";

        // BootcampMember:
        public const string bootcampMemberInvalidId = "Bootcamp member's Id is invalid.";
        public const string bootcampMemberNotFound = "Bootcamp member not found.";
    }
}