MUNICIPAL SERVICES APPLICATION
==============================

1. PROJECT OVERVIEW
-------------------

The Municipal Services Application is a C# Windows Forms application developed
using the .NET Framework.

The purpose of the application is to improve communication and engagement
between residents and their municipality.

The current version of the application allows residents to report municipal
service-delivery issues. Future versions of the application will include
Local Events and Announcements and Service Request Status functionality.


2. SYSTEM REQUIREMENTS
----------------------

To compile and run the application, the following are required:

- Microsoft Windows
- Microsoft Visual Studio
- .NET Framework 4.7.2
- C# Windows Forms support


3. HOW TO OPEN THE PROJECT
--------------------------

1. Open Microsoft Visual Studio.

2. Select "Open a project or solution".

3. Navigate to the MunicipalServicesApp project folder.

4. Open the MunicipalServicesApp solution (.sln) file.

5. Wait for Visual Studio to load the solution and its dependencies.


4. HOW TO COMPILE THE APPLICATION
---------------------------------

1. Open the MunicipalServicesApp solution in Visual Studio.

2. From the Visual Studio menu, select:

   Build > Build Solution

   Alternatively, press Ctrl + Shift + B.

3. Check the Visual Studio Output or Error List and confirm that the
   application builds successfully without errors.


5. HOW TO RUN THE APPLICATION
-----------------------------

1. Open the project in Visual Studio.

2. Build the solution.

3. Press F5 or select:

   Debug > Start Debugging

4. The Municipal Services Main Menu will open.


6. USING THE MAIN MENU
----------------------

The Main Menu provides access to the municipal services available in the
application.

The current version provides the following options:

- Report an Issue
- Local Events and Announcements
- Service Request Status

Report an Issue is currently available.

Local Events and Announcements and Service Request Status are reserved for
future implementation.


7. HOW TO REPORT AN ISSUE
-------------------------

1. From the Main Menu, select "Report an Issue".

2. Enter the location where the municipal issue occurred.

   Example:
   Main Street, Johannesburg

3. Select the appropriate issue category.

   Available categories may include:

   - Roads
   - Water and Sanitation
   - Electricity
   - Waste Management
   - Public Safety
   - Other

4. Enter a detailed description of the issue.

   Example:
   Large pothole causing an obstruction in the road.

5. If required, click the Browse button to attach an image or document
   relating to the issue.

6. The progress indicator will update as information is entered.

7. Click Submit to submit the report.

8. The application validates the required information before accepting
   the report.

9. After successful submission, a confirmation message is displayed
   containing a unique reference number and the current status.

   Example:

   Reference Number: MS-0001
   Status: Submitted

10. Keep the reference number for future service-request tracking.


8. REQUIRED INFORMATION
-----------------------

The following information must be provided before an issue can be submitted:

- Location
- Category
- Description

An attachment can also be added to provide supporting evidence.

If required information is missing, the application displays an appropriate
warning message and prevents the report from being submitted.


9. ATTACHING AN IMAGE OR DOCUMENT
---------------------------------

1. Click the Browse button.

2. Select an appropriate image or document from the computer.

3. Click Open.

4. The selected file path will appear in the attachment field.

Supported files include common image, PDF and Microsoft Word document formats.


10. PROGRESS INDICATOR
----------------------

The Report Issue form contains a progress indicator to encourage residents
to complete their reports.

The progress indicator increases as the user provides:

- Location
- Category
- Description
- Attachment

Encouraging messages are displayed based on the amount of information
completed.


11. CLEARING THE FORM
---------------------

Click the Clear button to remove the information currently entered into the
Report Issue form.

This clears:

- Location
- Category
- Description
- Attachment

The progress indicator is also reset.


12. RETURNING TO THE MAIN MENU
------------------------------

Click the Back button on the Report Issue form to close the form and return
to the Main Menu.


13. EXITING THE APPLICATION
---------------------------

Click the Exit button on the Main Menu.

The application will request confirmation before closing.


14. DATA STORAGE
----------------

Reported municipal issues are represented using the ReportedIssue class.

The application stores submitted issues in a List<ReportedIssue> data
structure through the IssueRepository class.

Each submitted issue contains information such as:

- Reference Number
- Location
- Category
- Description
- Attachment Path
- Date Reported
- Status

The current implementation stores this information in memory while the
application is running.


15. USER ENGAGEMENT STRATEGY
----------------------------

The application implements a digital issue-reporting strategy to improve
engagement between residents and the municipality.

Residents can submit service-delivery problems and receive immediate
confirmation that their report has been received.

Each report receives a unique reference number and an initial status of
"Submitted". This provides a foundation for the Service Request Status
functionality that will be implemented in a future version.

The progress indicator and encouraging messages provide additional user
engagement while a resident completes a report.


16. CURRENT FUNCTIONALITY
-------------------------

The current version includes:

- Municipal Services Main Menu
- Digital issue reporting
- Location entry
- Issue category selection
- Detailed issue descriptions
- Image/document attachments
- Input validation
- Dynamic progress indicator
- Encouraging user feedback
- Unique service-request reference numbers
- Initial service-request status
- In-memory List data structure for reported issues
- Clear functionality
- Navigation back to the Main Menu
- Exit confirmation


17. FUTURE FUNCTIONALITY
------------------------

The application is designed to be extended in future development stages.

Future functionality will include:

- Local Events and Announcements
- Service Request Status
- Additional municipal engagement and service-delivery functionality


18. APPLICATION DETAILS
-----------------------

Application Name: MunicipalServicesApp
Application Type: Windows Forms Application
Programming Language: C#
Framework: .NET Framework 4.7.2
Development Environment: Microsoft Visual Studio