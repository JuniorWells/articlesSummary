using Microsoft.EntityFrameworkCore;
using BlogDemo.API.Models;

namespace BlogDemo.API.Context
{
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BlogContext(
        serviceProvider.GetRequiredService<
        DbContextOptions<BlogContext>>()))
        {
            if (context.BlogPost.Any()) { return; }
            
            context.BlogPost.AddRange(
            new BlogPost
            {
                Title = "Watch Now: 52 wildfires break out in the last 24 hours across Greece",
                Category = "environment",
                SubCategory = "Greece",
                Description =
                    "According to the Greece Fire Service, 52 wildfires broke out in a 24 hour period, stoked by strong winds and high temperatures.",
                AuthorName = "VideoElephant",
                CreatedAt = "July 6, 2022",
                Cover = "https://bloximages.newyork1.vip.townnews.com/richmond.com/content/tncms/assets/v3/editorial/2/a5/2a5144a2-a052-5a9b-bb61-6de63c7ac3a6/62c5b18e18ae1.preview.jpg?crop=800%2C420%2C0%2C14&resize=800%2C420&order=crop%2Cresize"
            },  new BlogPost 
            {
                Title = "Walmart+ offers grocery delivery add-on, Disney cocktail costs $5K, American Idol champ speaks out",
                Category = "walmart+",
                SubCategory = "online-delivery",
                Description =
                    "Yahoo Finance Live anchors discuss Walmart offering a grocery delivery add-on for it's Walmart+ subscribers, Disney's $5,000 'Star Wars' themed cocktail, and American Idol contestant Caleb Johnson speaking out against his own debut.",
                AuthorName = "VideoElephant",
                CreatedAt = "July 6, 2022",
                Cover = "https://s.yimg.com/ny/api/res/1.2/6k8bVNiqZ3de8CBOm8RqNg--/YXBwaWQ9aGlnaGxhbmRlcjt3PTEyMDA7aD02NzU-/https://s.yimg.com/hd/cp-video-transcode/production/f42d2f37-651b-3b24-b920-2afa6120bd93/2022-07-06/16-13-06/ed3c7395-4311-51de-868c-d3906bf0bb9f/stream_1280x720x0_v2_3_0.jpg"
            },  new BlogPost
            {
                Title = "Elon Musk's Tesla no longer the world's top seller of electric cars - New York Post",
                Category = "tesla",
                SubCategory = "Elon Musk",
                Description = "Elon Musk's Tesla no longer the world's top seller of electric carsNew York Post Tesla is no longer the world's largest EV producerAxios Tesla is still the world’s largest electric car producer despite what you are hearingElectrek.co Tesla's biggest competito…",
                AuthorName = "feedfeeder",
                CreatedAt = "July 6, 2022",
                Cover = "https://cdn.biztoc.com/og/8szed4f4.jpg"
            },  new BlogPost
            {
                Title = "Apple is building a Lockdown Mode to fend off cyberattacks on high-profile users",
                Category = "apple",
                SubCategory = "technology",
                Description =
                    "Apple has announced Lockdown Mode, an \"extreme\" level of security designed for a \"very small number of users who face grave, targeted threats.\" It will be available this fall when the company rolls out iOS 16, iPadOS 16 and macOS Ventura",
                AuthorName = "Kris Holt",
                CreatedAt = "July 6, 2022",
                Cover = "https://s.yimg.com/os/creatr-uploaded-images/2022-01/353598f0-7765-11ec-bbbf-9f0ea07ea914"
            },  new BlogPost
            {
                Title = "China says India's frequent investigations into Chinese firms have chilling impact on business confidence",
                Category = "finance",
                SubCategory = "technology",
                Description = "“Frequent” investigations into local units of Chinese firms by Indian authorities “impedes the improvement of business environment” in India and “chills the confidence and willingness” of other forei...",
                AuthorName = "Manish Singh",
                CreatedAt = "July 6, 2022",
                Cover = "https://techcrunch.com/wp-content/uploads/2022/07/GettyImages-923835828.jpg?w=640"
            },  new BlogPost
            {
                Title = "Ethereum testnet Merge mostly successful — 'Hiccups will not delay the Merge.' - Cointelegraph",
                Category = "crypto",
                SubCategory = "technology",
                Description = "Ethereum has just completed the second-to-last Merge trial on the Sepolia testnet, with the next test just several weeks away before eventually being implemented on the mainnet",
                AuthorName = "Felix Ng",
                CreatedAt = "July 7, 2022",
                Cover = "https://images.cointelegraph.com/images/1200_aHR0cHM6Ly9zMy5jb2ludGVsZWdyYXBoLmNvbS91cGxvYWRzLzIwMjItMDcvODZhOGZlZjgtZDQ3Yy00NTI3LTg5ZTctZmQ5MzE5NzYwMzg0LmpwZw==.jpg"
            }
            );
            context.SaveChanges();
        }
    }
}

}