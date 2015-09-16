public class TweetBot
    {
        public OAuthTokens authTwitter(string ConsumerKey, string ConsumerSecret, string AccessToken, string AccessTokenSecret)  {
            OAuthTokens tokens = new OAuthTokens();
            tokens.ConsumerKey = ConsumerKey;
            tokens.ConsumerSecret= ConsumerSecret;
            tokens.AccessToken = AccessToken;
            tokens.AccessTokenSecret=AccessTokenSecret;
            return tokens;
        }
        public string sendTweet(string tweet, OAuthTokens tokens)
        {
            StatusUpdateOptions options = new StatusUpdateOptions() { UseSSL = true, APIBaseAddress = "http://api.twitter.com/1.1/" };
            TwitterResponse<TwitterStatus> response = TwitterStatus.Update(tokens, tweet, options);
            if (response.Result == RequestResult.Success)
            {
                return "bueno ";
            }
            else
            {
                return "malo ";
            }
        }
    }
