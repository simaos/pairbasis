# pairbasis
Intentionally poorly-designed and small web application, without test automation, to provide a basis for pair programming interviews, refactoring and/or test automation workshops.

It has a JavaScript/HTML UI client talking to a C# RESTful web service that reads a text file and filters results. Data is filtered by both the service and the client.

The goal was short and simple to understand code but with a complex enough structure to provide refactoring opporunities and test automation opportunities at multiple layers.

Suggested uses:
- Basis for pair programming interviews. For example "let's improve this" or "let's automate tests for this". You will quickly see a candidate's techniques for addressing coupling, refactoring and making choices about which levels to test at - from unit through to full system.
- Workshops in refactoring and test automation. Including the relationship between the two.
- Workshops in test automation pyramid balancing trade-offs (https://martinfowler.com/bliki/TestPyramid.html).
