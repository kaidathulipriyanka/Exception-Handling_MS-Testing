namespace MoodAnalyzer
{
         
            public class MoodAnalysisException : Exception
        {
            public enum ExceptionType
            {
                NULL_MOOD,
                EMPTY_MOOD,
                NO_SUCH_CLASS,
                NO_SUCH_METHOD,
                NO_SUCH_FIELD
            }

            private readonly ExceptionType type;

            public MoodAnalysisException(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }
        }

        public class MoodAnalyzer
        {
            private string message;

            public MoodAnalyzer()
            {
                this.message = "I am in Any Mood";
            }

            public MoodAnalyzer(string message)
            {
                this.message = message;
            }

            public string AnalyzeMood()
            {
                try
                {
                    if (string.IsNullOrEmpty(message))
                    {
                        throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MOOD, "Mood should not be empty");
                    }
                    if (message.ToLower().Contains("sad"))
                    {
                        return "SAD";
                    }
                    return "HAPPY";
                }
                catch (NullReferenceException)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MOOD, "Mood should not be null");
                }
            }
        }

        public class MoodAnalyzerFactory
        {
            public static MoodAnalyzer CreateMoodAnalyzerObject(string className, string constructorParameter, string v)
            {
                try
                {
                    Type type = Type.GetType(className);
                    return (MoodAnalyzer)Activator.CreateInstance(type, constructorParameter);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
                catch (MissingMethodException)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Constructor not found");
                }
            }

        public static MoodAnalyzer CreateMoodAnalyzerObject(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }

        public class MoodAnalyzerReflector
        {
            public static string InvokeAnalyzeMood(string message, string v)
            {
                try
                {
                    MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
                    Type type = moodAnalyzer.GetType();
                    System.Reflection.MethodInfo methodInfo = type.GetMethod("AnalyzeMood");
                    return (string)methodInfo.Invoke(moodAnalyzer, null);
                }
                catch (NullReferenceException)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Method not found");
                }
            }

            public static void ChangeMoodDynamically(MoodAnalyzer moodAnalyzer, string fieldName, string value)
            {
                try
                {
                    Type type = moodAnalyzer.GetType();
                    System.Reflection.FieldInfo fieldInfo = type.GetField(fieldName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                    fieldInfo.SetValue(moodAnalyzer, value);
                }
                catch (NullReferenceException)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_FIELD, "Field not found");
                }
            }

        public static string InvokeAnalyzeMood(string v)
        {
            throw new NotImplementedException();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {

            Program program = new Program();
        }
    }
}
