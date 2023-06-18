namespace SampleNuGet.Tests.Tests.Ai.Spam;

public class SpamCheck1
{
    [Fact]
    public void SpamCheckMethod1()
    {
        const string spam = "🎉 Wow, this time ARBITRUM is giving away coins in the NOVA network, " +
                            "everyone has the opportunity to get a certain number of coins, " +
                            "I advise you not to miss this giveaway. " +
                            "✔️ This one will give away 1️⃣0️⃣0️⃣.0️⃣0️⃣0️⃣ 💲 NOVA!  " +
                            "➡️ https://arbitrumfoundation.clalm.one " +
                            "❗ ️Very simple steps, go to the site and read the rules, " +
                            "spend a minute of your life, but get the opportunity to EARN!";

        var result = Utils.BingAi.DetectSpamAi.DetectSpam(spam);
        
        Assert.True(result.Item1 != null && result.Item1.Value);
    }
}