using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace mask
{
    class Program
    {

        static string TestFolder = @"C:\Users\Karol\semestr 2\computervision\test";
        static string PredictionFolder = @"C:\Users\Karol\semestr 2\computervision\prediction";
        static string url = "https://customvisionmask-prediction.cognitiveservices.azure.com/";
        static string PredictionKey = "ea6e5846aece4f21b4621ac8f1d961c2";
        static string ProjetId = "dbb3d2a7-3db5-4435-8869-19098d675be4";
        static string PublishedName = "Iteration1";



        static async Task Main(string[] args)
        {
            Console.WriteLine("Prediction");

          var predResult = await PredictionTest();

           foreach (var result in predResult)
            {
               Console.WriteLine($"{ result.Key } - { result.Value * 100 }");
           }

        }

      

        static async Task<ImagePrediction> predict(string imageFile)
        {
    

            CustomVisionPredictionClient CustomVisionPredictionClient = new CustomVisionPredictionClient()
            {
                Endpoint = url,
                ApiKey = PredictionKey
            };

            using (var imageStream = new FileStream(imageFile, FileMode.Open))
            {

                var pred = await CustomVisionPredictionClient.ClassifyImageAsync
                    (new Guid(ProjetId), PublishedName, imageStream);
                return pred;
            };
        }


        static async Task<Dictionary<string, double>> PredictionTest()
        {
            var results = new Dictionary<string, double>();

            int predicted = 0;
            int correct = 0;

            var testFolders = Directory.EnumerateDirectories(TestFolder);

            foreach (var testFolder in testFolders)
            {
                var testTagName = Path.GetFileName(testFolder);
                var predictionsFolder = Path.Combine(PredictionFolder, testTagName);
                if (!Directory.Exists(predictionsFolder))
                {
                    Directory.CreateDirectory(predictionsFolder);
                }
            }

            foreach (var testFolder in testFolders)
            {
                int tagP = 0;
                int tagCorrect = 0;

                var testTagName = Path.GetFileName(testFolder);
                Console.WriteLine($"Processing { testTagName }...");

                var testImages = Directory.GetFiles(testFolder);
                foreach (var testImage in testImages)
                {
                    var testImageFileName = Path.GetFileName(testImage);

                    var predictions = await predict(testImage);
                    var topPredicton = predictions.Predictions.OrderByDescending(q => q.Probability).FirstOrDefault();

                    predicted++;
                    tagP++;

                    bool isCorrect = testTagName == topPredicton.TagName;
                    if (isCorrect)
                    {
                        correct++;
                        tagCorrect++;
                    }

                    var temp = Console.ForegroundColor;
                    Console.ForegroundColor = isCorrect ? ConsoleColor.Green : ConsoleColor.Red;
                    Console.WriteLine($"    { testImageFileName } przewidziany jako { topPredicton.TagName } z pradopodobienstwem { (int)(topPredicton.Probability * 100) }");
                    Console.ForegroundColor = temp;


                    File.Copy(testImage, Path.Combine(PredictionFolder, topPredicton.TagName, $"{ testTagName }_{ testImageFileName }"));
                }

                results.Add(testTagName, (double)tagCorrect / (double)tagP);


            }

            results.Add("Podsumowujac jest", (double)correct / (double)predicted);
            return results;
        }


    }
}
