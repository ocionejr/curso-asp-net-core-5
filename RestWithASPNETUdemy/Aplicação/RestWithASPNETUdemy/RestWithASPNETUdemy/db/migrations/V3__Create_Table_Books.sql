CREATE TABLE public.books (
	id serial NOT NULL,
	author text NULL,
	launch_date timestamp(0) NOT NULL,
	price numeric(2) NOT NULL,
	title text NULL
);