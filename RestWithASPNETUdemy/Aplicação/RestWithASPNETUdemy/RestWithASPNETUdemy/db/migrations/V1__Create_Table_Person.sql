﻿CREATE TABLE public.person (
	id serial NOT NULL,
	address varchar(100) NOT NULL,
	first_name varchar(80) NOT NULL,
	gender varchar(6) NOT NULL,
	last_name varchar(80) NOT NULL,
	CONSTRAINT person_pk PRIMARY KEY (id)
);