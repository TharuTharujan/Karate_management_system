## Database Setup
Visual Studio → Project → Add new item → Data → Service based database → Name: Kickblast_Judo_Management_System and then click add now database created 
Then  Server Explorer → Data Connection → Kickblast_Judo_Management_System.mdf → Table → Add new table 
Run the following query in separete seperate table 

**Table 1 - Athlete:** (paste Athlete query)
CREATE TABLE [dbo].[Athlete] (
    [Athlete_ID]      INT           NOT NULL,
    [Athlete_name]    VARCHAR (50)  NOT NULL,
    [NIC_No]          VARCHAR (20)  NOT NULL,
    [Contact_No]      INT           NOT NULL,
    [Address]         VARCHAR (100) NOT NULL,
    [Current_weight]  INT           NOT NULL,
    [Weight_category] VARCHAR (50)  NOT NULL,
    [Height]          INT           NOT NULL,
    [BMI_index]       VARCHAR (50)  NOT NULL,
    [Blood_group]     VARCHAR (5)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Athlete_ID] ASC)
);

**Table 2 - Trainer:** (paste Trainer query)
CREATE TABLE [dbo].[Trainer] (
    [Trainer_ID]    INT          NOT NULL,
    [Trainer_name]  VARCHAR (50) NOT NULL,
    [NIC_No]        VARCHAR (50) NOT NULL,
    [Contact_No]    INT          NOT NULL,
    [Address]       VARCHAR (50) NOT NULL,
    [Qualification] VARCHAR (50) NOT NULL,
    [Experience]    VARCHAR (50) NOT NULL,
    [Salary]        INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Trainer_ID] ASC)
);

**Table 3 - Training_plan:** (paste Training_plan query)
CREATE TABLE [dbo].[Training_plan] (
    [Id]            INT          NOT NULL,
    [Training_plan] VARCHAR (50) NOT NULL,
    [Price]         VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

**Table 4 - Weight_category:** (paste Weight_category query)
CREATE TABLE [dbo].[Weight_category] (
    [Id]                      INT          NOT NULL,
    [Category]                VARCHAR (50) NULL,
    [Upper_weight_limit_(kg)] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

**Table 5 - Coaching:** (paste Coaching query)
CREATE TABLE [dbo].[Coaching] (
    [Coaching_ID]                         INT          NOT NULL,
    [Date_of_coaching_creation]           VARCHAR (50) NOT NULL,
    [Athlete_ID]                          VARCHAR (50) NOT NULL,
    [Athlete_name]                        VARCHAR (50) NOT NULL,
    [Current_weight]                      INT          NOT NULL,
    [Weight_category]                     VARCHAR (50) NOT NULL,
    [Trainer_ID]                          INT          NOT NULL,
    [Trainer_name]                        VARCHAR (50) NOT NULL,
    [Training_plan]                       VARCHAR (50) NOT NULL,
    [Training_start_date]                 VARCHAR (50) NOT NULL,
    [Training_end_date]                   VARCHAR (50) NOT NULL,
    [No_of_weeks]                         INT          NOT NULL,
    [Total_Amount_for_Training]           INT          NOT NULL,
    [Private_Coaching_Hours]              INT          NOT NULL,
    [Private_Coaching_Start_Date]         VARCHAR (50) NOT NULL,
    [Private_Coaching_End_Date]           VARCHAR (50) NOT NULL,
    [Total_Amount_for_Coaching]           INT          NOT NULL,
    [Total_Training_and_Coaching_Amount ] INT          NOT NULL,
    [No_of_weeks1]                        INT          NOT NULL,
    [Training_fees]                       VARCHAR (50) NOT NULL,
    [Private_coaching_fees]               INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Coaching_ID] ASC)
);

**Table 6 - Competition:** (paste Competition query)
CREATE TABLE [dbo].[Competition] (
    [Competition_ID]               INT          NOT NULL,
    [Date_of_competition_creation] VARCHAR (50) NOT NULL,
    [Coaching_ID]                  INT          NOT NULL,
    [Date_of_coaching_creation]    VARCHAR (50) NOT NULL,
    [Athlete_ID]                   INT          NOT NULL,
    [Athlete_name]                 VARCHAR (50) NOT NULL,
    [Current_weight]               INT          NOT NULL,
    [Weight_category]              VARCHAR (50) NOT NULL,
    [Date_of_competition]          VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Competition_ID] ASC)
);










