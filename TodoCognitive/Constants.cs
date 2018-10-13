namespace TodoCognitive
{
    public static class Constants
    {
        public static readonly string AuthenticationTokenEndpoint = "https://api.cognitive.microsoft.com/sts/v1.0";

        public static readonly string BingSpeechApiKey = "b62faa092cff4207b7df326efd5bddd6";
        public static readonly string SpeechRecognitionEndpoint = "https://speech.platform.bing.com/speech/recognition/";
        public static readonly string AudioContentType = @"audio/wav; codec=""audio/pcm""; samplerate=16000";

        public static readonly string BingSpellCheckApiKey = "ee512a7641974ae39f2b20b25ae93bd9";
        public static readonly string BingSpellCheckEndpoint = "https://api.cognitive.microsoft.com/bing/v7.0/SpellCheck";

        public static readonly string TextTranslatorApiKey = "77c0d3bc7486428ba856f4abc361a86f";
        public static readonly string TextTranslatorEndpoint = "https://api.microsofttranslator.com/v2/http.svc/translate";

        public static readonly string FaceApiKey = "62798f14d8c14399ab3c69883715154a";
        public static readonly string FaceEndpoint = "https://brazilsouth.api.cognitive.microsoft.com/face/v1.0";

        public static readonly string AudioFilename = "Todo.wav";
    }
}
