using DotNetEnv;

public class Initialize
{
    public static string Database()
    {
        Env.Load();

        return Env.GetString("DATABASE_STRING");
    }
}
