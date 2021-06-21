ALTER TABLE public.person DROP COLUMN enabled;
ALTER TABLE public.person ADD enabled bool NOT NULL DEFAULT true;

