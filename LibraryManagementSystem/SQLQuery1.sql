ALTER TABLE books
ADD image VARCHAR(MAX) NULL

SELECT * FROM books

DELETE FROM books

CREATE TABLE issues
(
	id INT PRIMARY KEY IDENTITY(1,1),
	issue_id VARCHAR(MAX) NULL,
	full_name VARCHAR(MAX) NULL,
	contact VARCHAR(MAX) NULL,
	email VARCHAR(MAX) NULL,
	book_title VARCHAR(MAX) NULL,
	author VARCHAR(MAX) NULL,
	image VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	issue_date VARCHAR(MAX) NULL,
	return_date VARCHAR(MAX) NULL,
	date_insert VARCHAR(MAX) NULL,
	date_update VARCHAR(MAX) NULL,
	date_delete VARCHAR(MAX) NULL
)

SELECT * FROM issues