# Examination: CI/CD & Cloud - Language API
This is my individual examination project. It is a .NET 8 Web API that can encrypt and decrypt text using the Caesar Cipher algorithm. The main goal of the project was to set up a working CI/CD pipeline that automatically tests the code and deploys it to AWS Elastic Beanstalk.

## How it works

The API has two main endpoints:
* `POST /encrypt`: Takes a text and shifts the characters to encrypt it.
* `POST /decrypt`: Takes the encrypted text and shifts it back to the original.

You can try the API here:
[**\[http://individuell-cicd-env.eba-kzumjip5.eu-north-1.elasticbeanstalk.com/swagger]**]

---

## Project Structure

I have structured the project into two separate folders to keep the code clean and to make the testing easier:

```text
Examination_CICD/
├── Examination_CICD/       # The main API code (Program.cs etc.)
├── LanguageApi.Tests/      # The test project
└── .github/workflows/      # The pipeline configuration
