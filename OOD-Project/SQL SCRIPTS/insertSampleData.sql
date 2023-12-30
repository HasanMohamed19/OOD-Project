
-- inactive/pending users

INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (40,'202309403','845661345','202309403@elms.bh',3,3);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (41,'202304589','578901534','202304589@elms.bh',3,3);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (42,'202307814','134534890','202307814@elms.bh',2,3);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (43,'202309403','845661345','202309403@elms.bh',3,1);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (44,'202304589','578901534','202304589@elms.bh',3,1);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (45,'202307814','134534890','202307814@elms.bh',2,1);

INSERT INTO [dbo].[student]	(student_id, user_id, first_name, last_name, phone_number, dob, cpr, gender, major_id, student_university_id)
VALUES					    (40,40,'Taffash','Taffash','24567890','12/12/2005','845661345','M',8,'202309403');
INSERT INTO [dbo].[student]	(student_id, user_id, first_name, last_name, phone_number, dob, cpr, gender, major_id, student_university_id)
VALUES					    (41,43,'Taffash','Taffash','24567890','12/12/2005','845661345','M',8,'202309403');
INSERT INTO [dbo].[student]	(student_id, user_id, first_name, last_name, phone_number, dob, cpr, gender, major_id, student_university_id)
VALUES					    (42,41,'Habiba','Hilwa','15678934','8/8/2005','578901534','F',4,'202304589');
INSERT INTO [dbo].[student]	(student_id, user_id, first_name, last_name, phone_number, dob, cpr, gender, major_id, student_university_id)
VALUES					    (44,44,'Habibti','Hilwa','15678934','8/8/2005','578901534','F',5,'202304589');
INSERT INTO [dbo].[teacher]	(teacher_id, branch_id,user_id, first_name, last_name, phone_number, dob, cpr, gender, programme_id, teacher_university_id)
VALUES					    (45,6,42,'Jimbasi','Machboos','93576345','12/12/1979','134534890','M',6,'202307814');
INSERT INTO [dbo].[teacher]	(teacher_id, branch_id,user_id, first_name, last_name, phone_number, dob, cpr, gender, programme_id, teacher_university_id)
VALUES					    (46,6,45,'Jimbasi','Machboos','93576345','12/12/1979','134534890','M',6,'202307814');


-- Students (Users first)
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (20,'202201920','040291920','202201920@elms.bh',3,2);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (21,'202101970','034233334','202101970@elms.bh',3,2);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (22,'201794331','023930222','201794331@elms.bh',3,2);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (23,'201787331','403092922','201787331@elms.bh',3,2);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (24,'202312830','765419023','202312830@elms.bh',3,2);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (25,'202012333','813455431','202012333@elms.bh',3,2);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (26,'202100454','856467344','202100454@elms.bh',3,2);
-- Students
INSERT INTO [dbo].[student]	(student_id, user_id, first_name, last_name, phone_number, dob, cpr, gender, major_id, student_university_id)
VALUES					    (20,20,'Bader','Haloomi','32423344','12/12/2004','040291920','M',1,'202201920');
INSERT INTO [dbo].[student]	(student_id, user_id, first_name, last_name, phone_number, dob, cpr, gender, major_id, student_university_id)
VALUES					    (21,21,'Isa','Sarookh','34544564','6/12/2003','034233334','M',2,'202101970');
INSERT INTO [dbo].[student]	(student_id, user_id, first_name, last_name, phone_number, dob, cpr, gender, major_id, student_university_id)
VALUES					    (22,22,'Jalal','Bahrani','92576245','10/3/2001','023930222','M',3,'201794331');
INSERT INTO [dbo].[student]	(student_id, user_id, first_name, last_name, phone_number, dob, cpr, gender, major_id, student_university_id)
VALUES					    (23,23,'Maleeha','Sukkar','04781346','3/3/2000','403092922','F',5,'201787331');
INSERT INTO [dbo].[student]	(student_id, user_id, first_name, last_name, phone_number, dob, cpr, gender, major_id, student_university_id)
VALUES					    (24,24,'Lina','Adnan','83561346','2/12/2003','765419023','F',6,'202312830');
INSERT INTO [dbo].[student]	(student_id, user_id, first_name, last_name, phone_number, dob, cpr, gender, major_id, student_university_id)
VALUES					    (25,25,'Bassim','Alhawaj','85642457','12/12/1999','813455431','M',7,'202012333');
INSERT INTO [dbo].[student]	(student_id, user_id, first_name, last_name, phone_number, dob, cpr, gender, major_id, student_university_id)
VALUES					    (26,26,'Sanaa','Qasim','14638357','7/2/2002','856467344','F',11,'202100454');

-- Teachers (Users first)
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (30,'201709304','934289333','201709304@elms.bh',2,2);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (31,'201985044','483202233','201985044@elms.bh',2,2);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (32,'201693400','789393993','201693400@elms.bh',2,2);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (33,'202003991','002930204','202003991@elms.bh',2,2);
INSERT INTO [dbo].[user]			(user_id, username, password, email, role_id, status_id)
VALUES (34,'202309400','038299239','202309400@elms.bh',2,2);
-- Teachers
INSERT INTO [dbo].[teacher]	(teacher_id, branch_id,user_id, first_name, last_name, phone_number, dob, cpr, gender, programme_id, teacher_university_id)
VALUES					    (30,1,30,'Salman','Mahdi','93428933','12/12/1989','934289333','M',1,'201709304');
INSERT INTO [dbo].[teacher]	(teacher_id, branch_id,user_id, first_name, last_name, phone_number, dob, cpr, gender, programme_id, teacher_university_id)
VALUES					    (31,8,31,'Hana','Ghana','89320223','12/12/1986','483202233','F',5,'201985044');
INSERT INTO [dbo].[teacher]	(teacher_id, branch_id,user_id, first_name, last_name, phone_number, dob, cpr, gender, programme_id, teacher_university_id)
VALUES					    (32,5,32,'Khabib','Habib','23464568','12/12/1989','789393993','M',6,'201693400');
INSERT INTO [dbo].[teacher]	(teacher_id, branch_id,user_id, first_name, last_name, phone_number, dob, cpr, gender, programme_id, teacher_university_id)
VALUES					    (33,7,33,'Mona','Lisa','26343685','12/12/1989','002930204','F',2,'202003991');
INSERT INTO [dbo].[teacher]	(teacher_id, branch_id,user_id, first_name, last_name, phone_number, dob, cpr, gender, programme_id, teacher_university_id)
VALUES					    (34,2,34,'Michael','Mandi','73456245','12/12/1989','038299239','M',3,'202309400');

-- Announcements (global)
INSERT INTO [dbo].[announcement] (announcement_id, body, date, is_global, title, announcement_type_id)
VALUES							(50,'Hello all, we have a great announcement for you. Next week will be a holiday, so you can spend your time enjoying it without school. Have fun!','1/9/2023',1,'Holiday Announcement',1);
INSERT INTO [dbo].[announcement] (announcement_id, body, date, is_global, title, announcement_type_id)
VALUES							(51,'Hello all, please remember to frequently change your passwords and be careful on the internet.','2/9/2023',1,'Security Reminder',1);
INSERT INTO [dbo].[announcement] (announcement_id, body, date, is_global, title, announcement_type_id)
VALUES							(52,'Hello all, an ID card was found near the bin in the entrance to campus. If this was your card, please come pick it up in the security office.','9/9/2023',1,'Lost ID Card',1);
INSERT INTO [dbo].[announcement] (announcement_id, body, date, is_global, title, announcement_type_id)
VALUES							(53,'Hello all, we have career opportunities for you. Check the website for more information.','7/7/2023',1,'Career Opportunities',1);


-- Courses

INSERT INTO [dbo].[course] ([course_id], [name], [code], [description], [programme_id], [credits]) VALUES (10, N'Logistics and Transportation', N'LT6003    ', N'Logistic Operations and Basics', 5, 15)
INSERT INTO [dbo].[course] ([course_id], [name], [code], [description], [programme_id], [credits]) VALUES (11, N'Money', N'BS6009    ', N'Money in general', 2, 15)
INSERT INTO [dbo].[course] ([course_id], [name], [code], [description], [programme_id], [credits]) VALUES (12, N'Wall Design', N'FC8093    ', N'In depth about walls and various designs', 3, 15)

INSERT INTO [dbo].[section] ([section_id], [crn], [capacity], [teacher_id], [course_id], [report_path], [is_report_published]) VALUES (10, N'263454', 25, 31, 10, NULL, 0)
INSERT INTO [dbo].[section] ([section_id], [crn], [capacity], [teacher_id], [course_id], [report_path], [is_report_published]) VALUES (11, N'752444', 24, 33, 11, NULL, 0)
INSERT INTO [dbo].[section] ([section_id], [crn], [capacity], [teacher_id], [course_id], [report_path], [is_report_published]) VALUES (12, N'354777', 25, 34, 12, NULL, 0)

INSERT INTO [dbo].[class] ([class_id], [start_time], [end_time], [building], [room_number], [section_id], [week_day_id]) VALUES (30, N'12:00:00', N'14:00:00', N'36', N'203', 10, 2)
INSERT INTO [dbo].[class] ([class_id], [start_time], [end_time], [building], [room_number], [section_id], [week_day_id]) VALUES (31, N'08:00:00', N'10:00:00', N'36', N'203', 10, 3)
INSERT INTO [dbo].[class] ([class_id], [start_time], [end_time], [building], [room_number], [section_id], [week_day_id]) VALUES (32, N'12:00:00', N'14:00:00', N'36', N'201', 11, 2)
INSERT INTO [dbo].[class] ([class_id], [start_time], [end_time], [building], [room_number], [section_id], [week_day_id]) VALUES (33, N'14:00:00', N'16:00:00', N'36', N'201', 11, 6)
INSERT INTO [dbo].[class] ([class_id], [start_time], [end_time], [building], [room_number], [section_id], [week_day_id]) VALUES (34, N'10:00:00', N'12:00:00', N'36', N'206', 12, 4)
INSERT INTO [dbo].[class] ([class_id], [start_time], [end_time], [building], [room_number], [section_id], [week_day_id]) VALUES (35, N'08:00:00', N'10:00:00', N'36', N'202', 12, 3)

-- registration

INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (30, 20, 10, 67)
INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (31, 21, 10, 89)
INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (32, 21, 12, NULL)
INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (33, 21, 11, NULL)
INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (34, 22, 5, NULL)
INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (35, 22, 2, NULL)
INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (36, 22, 8, NULL)
INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (37, 23, 10, 77)
INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (38, 24, 10, 90)
INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (39, 24, 12, NULL)
INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (40, 25, 11, NULL)
INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (41, 25, 5, NULL)
INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (42, 26, 2, NULL)
INSERT INTO [dbo].[registration] ([registration_id], [student_id], [section_id], [student_grade]) VALUES (43, 26, 8, NULL)

