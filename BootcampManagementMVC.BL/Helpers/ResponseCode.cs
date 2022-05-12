namespace BootcampManagementMVC.BL.Helpers
{
    public static class ResponseCode
    {
        public const string bootcampGroupInvalidId = "Bootcamp's Id is invalid.";
        public const string bootcampGroupAlreadyExist = "Bootcamp already exist.";
        public const string bootcampGroupNotFound = "Bootcamp not found.";
        public const string bootcampGroupCannotBeChangedToInactive = "Bootcamp can't be changed to inactive since any member is still joining.";
    }
}