# Use an official PostgreSQL image as the base image
FROM postgres:latest
 
# Set environment variables for PostgreSQL
ENV POSTGRES_DB=testAssa
ENV POSTGRES_USER=jordomir
ENV POSTGRES_PASSWORD=Jordomir!
 
# Copy the SQL script to initialize the database
# COPY init.sql /docker-entrypoint-initdb.d/