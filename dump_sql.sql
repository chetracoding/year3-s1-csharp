CREATE TABLE [dbo].[sexes](
	[sex_id] [int] IDENTITY(1,1) NOT NULL,
	[label] [nvarchar](255) NOT NULL,
	[disabled] [bit] NULL
) ON [PRIMARY]

ALTER TABLE [dbo].[sexes] ADD  CONSTRAINT [DF_sex_disabled]  DEFAULT ((0)) FOR [disabled]

CREATE TABLE [dbo].[students](
	[student_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](255) NULL,
	[last_name] [varchar](255) NULL,
	[date_of_birth] [date] NULL,
	[place_of_birth] [nvarchar](255) NULL,
	[phone] [nvarchar](255) NULL,
	[student_code] [nvarchar](255) NULL,
	[fk_sex_id] [int] NULL
) ON [PRIMARY]