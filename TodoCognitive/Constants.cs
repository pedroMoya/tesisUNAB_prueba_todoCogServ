namespace TodoCognitive
{
    public static class Constants
    {
        public static readonly string AuthenticationTokenEndpoint = "https://api.cognitive.microsoft.com/sts/v1.0";

        public static readonly string BingSpeechApiKey = "_key_";
        public static readonly string SpeechRecognitionEndpoint = "https://speech.platform.bing.com/speech/recognition/";
        public static readonly string AudioContentType = @"audio/wav; codec=""audio/pcm""; samplerate=16000";

        public static readonly string BingSpellCheckApiKey = "__key__";
        public static readonly string BingSpellCheckEndpoint = "https://api.cognitive.microsoft.com/bing/v7.0/SpellCheck";

        public static readonly string TextTranslatorApiKey = "_key_";
        public static readonly string TextTranslatorEndpoint = "https://api.microsofttranslator.com/v2/http.svc/translate";

        public static readonly string FaceApiKey = "_key_";
        public static readonly string FaceEndpoint = "https://brazilsouth.api.cognitive.microsoft.com/face/v1.0";

        public static readonly string AudioFilename = "Todo.wav";
    }
}
