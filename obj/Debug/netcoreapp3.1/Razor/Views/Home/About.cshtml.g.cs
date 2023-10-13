#pragma checksum "C:\Users\megha\OneDrive\Desktop\Gurdeep_Fork_Assignment\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "852883b9ce60a22597d8ca9e5bca19d53eae865d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\megha\OneDrive\Desktop\Gurdeep_Fork_Assignment\Views\_ViewImports.cshtml"
using Gurdeep_Fork_Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\megha\OneDrive\Desktop\Gurdeep_Fork_Assignment\Views\_ViewImports.cshtml"
using Gurdeep_Fork_Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"852883b9ce60a22597d8ca9e5bca19d53eae865d", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceb415d480286f5079d526242cb2c187b3db1910", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\megha\OneDrive\Desktop\Gurdeep_Fork_Assignment\Views\Home\About.cshtml"
  
    ViewData["Title"] = "AboutUs";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css2?family=Autour+One&display=swap"">

<style>
    /* Define your green color palette */
    :root {
        --main-bg-color: #4CAF50; /* Main background color */
        --accent-color: #8BC34A; /* Accent color */
        --text-color: #333; /* Main text color */
        --button-color: #2E7D32; /* Button color */
        --link-color: #2196F3; /* Link color */
        --border-color: #C8E6C9; /* Border color */
    }

    /* Apply the color palette to the body */
    body {
        background-color: var(--main-bg-color);
        color: var(--text-color);
        font-family: Arial, sans-serif;
    }

    /* Header styling */
    header {
        background-color: var(--accent-color);
        padding: 20px;
        text-align: center;
        border-bottom: 4px solid var(--border-color);
    }

        header h1 {
            font-size: 36px;
            margin: 0;
            color: white;
        }

    /* Navigat");
            WriteLiteral(@"ion menu */
    nav {
        background-color: var(--accent-color);
        text-align: center;
    }

        nav ul {
            list-style-type: none;
            padding: 0;
        }

        nav li {
            display: inline;
            margin: 0 15px;
        }

        nav a {
            text-decoration: none;
            color: white;
            font-weight: bold;
            transition: color 0.3s;
        }

            nav a:hover {
                color: var(--button-color);
            }

    /* Main content container */
    .centered {
        background-color: white;
        width: 80%; /* Adjust the width as needed */
        max-width: 800px; /* Adjust the maximum width as needed */
        margin: 0 auto;
        padding: 20px;
        border: 1px solid #ccc;
        border-radius: 5px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        position: relative;
        top: 50%;
        transform: translateY(-50%);
        overflow-y: auto; /");
            WriteLiteral(@"* Enable vertical scrolling if content overflows */
        max-height: 80vh; /* Adjust the maximum height as needed */
    }

    /* Buttons */
    .button {
        background-color: var(--button-color);
        color: white;
        padding: 10px 20px;
        border: none;
        border-radius: 5px;
        font-weight: bold;
        cursor: pointer;
    }

        .button:hover {
            background-color: #388E3C;
        }

    /* Links */
    a {
        color: var(--link-color);
        text-decoration: none;
        transition: color 0.3s;
    }

        a:hover {
            color: #1976D2;
        }

    /* Unique styling for a specific element (adjust as needed) */
    .unique-element {
        background-color: #E8F5E9; /* Light green background */
        border: 2px solid var(--border-color);
        padding: 10px;
        margin: 10px 0;
    }

    /* Footer styling */
    footer {
        background-color: var(--accent-color);
        color: white");
            WriteLiteral(@";
        padding: 10px;
        text-align: center;
        border-top: 4px solid var(--border-color);
    }

    /* Use the 'Autour One' font for headings */
    h1, h2, h3, h4, h5, h6 {
        font-family: 'Autour One', cursive;
    }

    /* Use 'Autour One' for your main content text */
    body {
        font-family: 'Autour One', cursive;
    }

    /* Apply 'Autour One' to a specific class */
    .custom-font {
        font-family: 'Autour One', cursive;
    }

    /* Use 'Autour One' for links */
    a {
        font-family: 'Autour One', cursive;
    }

    /* Apply 'Autour One' to a unique element */
    .unique-element {
        font-family: 'Autour One', cursive;
    }

    /* Media queries for responsiveness (customize as needed) */

</style>

About Fork World
Our Passion for Forks
At Fork World, we are not just enthusiasts; we are devoted to the world of forks. Our passion for these humble yet essential dining tools has driven us to create a unique space fo");
            WriteLiteral(@"r fork lovers and connoisseurs alike.

Our Story
Our journey began when we realized the beauty and versatility of forks in our everyday lives. Forks aren't just utensils; they are symbols of culture, innovation, and craftsmanship. We set out to share our fascination with forks and bring you the most intriguing insights into the world of dining utensils.

A Fork for Every Occasion
Our mission is to help you discover the perfect fork for every dining experience. Whether you're exploring a vintage dining setting or opting for a modern, eco-friendly approach, we have forks to suit your taste.

Expert Guidance
We take pride in offering expert guidance, from understanding the materials used to craft forks to mastering proper dining etiquette. Our team of fork aficionados is dedicated to providing you with reliable, comprehensive, and up-to-date information.

A Vibrant Community
Fork World is not just a website; it's a vibrant community of individuals who share our passion for forks. Join us in lively di");
            WriteLiteral(@"scussions, share your fork-related experiences, and connect with like-minded enthusiasts. Together, we're redefining the world of dining utensils.

Discover Fork World
Explore the world of forks like never before. Whether you're a seasoned chef, a fine-dining enthusiast, or simply someone who appreciates a well-crafted fork, Fork World welcomes you to embark on a journey that celebrates the elegance and functionality of these everyday marvels.

Contact Us
We value your input and look forward to hearing from you. If you have any questions, suggestions, or fork-related stories to share, please don't hesitate to contact us. Your feedback fuels our passion and commitment.

Follow Us
Stay updated with the latest in the fork universe by following us on social media. Join our growing community of fork enthusiasts.

Thank you for being a part of Fork World. Your love for forks is our inspiration.");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591