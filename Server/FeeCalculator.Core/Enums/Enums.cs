namespace Core.Enums
{
    public enum DbError
    {
        OK = 0,
        ErrorCreate = -10,
        ErrorUpdate = -11,
        ErrorDelete = -12,
        EntityAlredyExists = -13,
        EntityNotFound = -14,
        WrongInputData = -15,
        EntityHasDependendRecords = -16,
        CommingModelIsNull = -17
    }

    public enum DbAction
    {
        NoAction = 0,
        Add = 1,
        Update = 2,
        Delete = 3
    }
}
