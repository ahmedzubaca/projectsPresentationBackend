(sql server is supposed to be installed an the computer) <br/>
Open projectsPresentationBackend.sln. <br/>
Open Package Manager Console. <br/>
Enter command: Add-Migration Initial. <br/>
Enter command: Update-Database. <br/>

This will create sql express database named ProjectsDb and within it table with data from ModelBuilderExtensions class. <br/>
Start the solution. <br/>

As separat project open React.js/TypeScript projectsPresentationFrontend.<br/>
run npm install <br/>
run npm start <br/>
application should be running on port 3000.
