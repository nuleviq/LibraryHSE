# LibraryManagmentSystem
In this solution, the local directory on the computer is selected as the database,
all entities and attributes are stored there. Since the project is presented and we
can show the solution, we did not consider it necessary to upload the database to cloud storage.
All the same, to run the program on another computer, you need to create the desired database
and change the link to the local database at the beginning of each page.
Templates for website from https://colorlib.com/wp/templates/

The application does not have a login selection window. That is, there is no way from one window to go to the entrance as a librarian or as a guest. In order to start the application you need to designate the page as the start page.

Sql script to create tables:

CREATE TABLE [dbo].[books] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [books_title ]      VARCHAR (50)  NULL,
    [books_image]       VARCHAR (MAX) NULL,
    [books_pdf]         VARCHAR (MAX) NULL,
    [books_video]       VARCHAR (MAX) NULL,
    [books_author_name] VARCHAR (50)  NULL,
    [books_isbn]        VARCHAR (50)  NULL,
    [avaliable_qty]     VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[issue_books] (
    [Id]                       INT          IDENTITY (1, 1) NOT NULL,
    [student_enrollment_no]    VARCHAR (50) NULL,
    [books_isbn]               VARCHAR (50) NULL,
    [books_issue_date]         VARCHAR (50) NULL,
    [books_approx_return_date] VARCHAR (50) NULL,
    [student_username]         VARCHAR (50) NULL,
    [is_books_return]          VARCHAR (50) NULL,
    [books_returned_date]      VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[librarian_registration] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [firstname] NCHAR (50)   NULL,
    [lastname]  VARCHAR (50) NULL,
    [username]  VARCHAR (50) NULL,
    [password]  VARCHAR (50) NULL,
    [email]     VARCHAR (50) NULL,
    [contact]   VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[penalty] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [penalty] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[student_registration] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [firstname]     VARCHAR (50)  NULL,
    [lastname]      VARCHAR (50)  NULL,
    [enrollment_no] VARCHAR (50)  NULL,
    [username]      VARCHAR (50)  NULL,
    [password]      VARCHAR (50)  NULL,
    [email]         VARCHAR (50)  NULL,
    [contact]       VARCHAR (50)  NULL,
    [student_img]   VARCHAR (MAX) NULL,
    [approved]      VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

