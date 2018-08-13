# Nhibernate.Net-Test
A Dot.Net Nhibernate test



This is a quickstart-guide-try-out for using NHibernate 2.0 on Visual Studio 2008.
You can find the quick start guide on their website..
Or you can also download the PDF file along with the project solutions.

#Pre-requisites (all included in Reference)
1) NUnit
2) Nuget
3) NHibernate

#How to -Test
1) Open up Solution using Visutal Studio 2008
2) Choose a "FirstSolution.Test" Project
3) To Test the codes  that can generate Schema, 
    - choose "GeneratesSchema_Fixture.cs" 
    - and within the method "Can_generate_schema(), 
    - right click and choose, "run test"
    
4) To Test the codes that can CRUD to db, 
    - choose "ProductRepository_Fixture.cs"
    - and within mothods starting with "Can_...()",
    - right click and choose, "run test"
    
    
