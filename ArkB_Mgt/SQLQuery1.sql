CREATE TABLE staff

(
	id INT PRIMARY KEY IDENTITY,
	employee_id VARCHAR(50) NULL,
	full_name VARCHAR(100) NULL,
	gender VARCHAR(10) NULL,
	contact_number VARCHAR(20) NULL,
	position VARCHAR(50) NULL,
	salary INT NULL,
	image VARCHAR(MAX) NULL,
	insert_date DATE NULL,
	update_date DATE NULL,
	delete_date DATE NULL
)

SELECT * FROM staff

ALTER TABLE staff
ADD status VARCHAR(20) NULL