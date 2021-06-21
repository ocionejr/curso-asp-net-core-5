-- public.users definition

-- Drop table

-- DROP TABLE public.users;

CREATE TABLE public.users (
	id serial NOT NULL,
	user_name varchar(50) NOT NULL DEFAULT '0',
	password varchar(130) NOT NULL DEFAULT '0',
	full_name varchar(120) NOT NULL,
	refresh_token varchar(500) NOT NULL DEFAULT '0',
	refresh_token_expiry_time timestamp(0) NULL DEFAULT NULL,
	PRIMARY KEY (id),
	UNIQUE (user_name)
);
