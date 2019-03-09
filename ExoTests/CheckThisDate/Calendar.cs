static class Calendar
{
    public static bool VerifyDate(int year, int month, int day)
    {
        return
            year < 2001 || year > 2099 ? false :
            month < 1 || month > 12 ? false :
            day < 1 || day > DaysInMonth(year, month) ? false : true;
    }

    private static int DaysInMonth(int year, int month)
    {
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12: return 31;
            case 4:
            case 6:
            case 9:
            case 11: return 30;
            case 2: return year % 4 == 0 ? 29 : 28;
            default: return 0;
        }
    }
}

