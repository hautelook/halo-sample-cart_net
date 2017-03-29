# E-commerce Cart Sample

The cart sample includes SpecFlow tests and plain old C# objects (POCOs) that model the functionality of a basic shopping cart.


## Requirements

The cart sample has the relevant NuGet packages that satisfies all the dependencies for the code to work.

Note: The cart sample solution has been tested on Windows 10 with Visual Studio Community 2017.

## Installation

   * Make sure you have a working internet connection.
   * Download and install Visual Studio (Visual Studio Community 2017).
   * Once installation is completed launch Visual Studio and goto Tools > Extensions and Updates.
   * Under 'Online' search for SpecFlow and install the SpecFlow for Visual Studio extension (SpecFlow for Visual Studio 2017). You may need to relaunch Visual Studio for the installation to work.

Note: We expect installation to take 20-40 minutes to setup based on your Internet connection. If you run into issues please feel free to reach out to us. We are happy to [help](#support).

## Running Tests

After installation, open up the halo-erp-sample-cart.sln file:

Method 1
  * Build the entire solution
  * From the Visual Studio menu goto Test > Windows > Test Explorer
  * Run All

Method 2
  * Build the entire solution
  * Double click on the features/Cart.feature file
  * Right click in the Code window and run 'Run SpecFlow Scenarios'

## Code Layout

Here is a high level overview of the important files in this project:

   * `features/cart.feature` - the gherkin language that describes scenarios (tests cases) for the sample cart code.
   * `features/FeatureContext.cs` - the SpecFlow file that is associated with the above `cart.feature` and executes tests.
   * `src/Cart.php` - the sample cart class

You may need to add additional files or classes to complete the assignment.

## Challenge

The first scenario has been written for you. Please implement the remaining scenarios in `features/cart.feature'. We are judging you on the design and the correctness of the code. Make whatever changes you want to the scenario implementations and source code to accomplish that goal. We are excited to see it! Zip up the directory and email it back to us. You can omit the `.git` and `bin` directories when creating the zip.

### Support

Need help? Please reach out to us! We know computers can be tricky things and we are happy to assist you. Our contact details are in the email we sent you. We will get back to you as soon as we can.
