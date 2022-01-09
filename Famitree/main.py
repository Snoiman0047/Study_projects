
from Family import Family


""" Father details """
father_name = input('Insert father name: ')
father_age = int(input('Insert father age: '))

""" Mother details """
mother_name = input('Insert mother name: ')
mother_age = int(input('Insert mother age: '))

""" Children details """
num_children = int(input('Insert amount of children: '))
children = {}
for index in range(num_children):
    """ Child details """
    child_name = input('Insert child name: ')
    child_age = input('Insert child age: ')
    children[child_name] = child_age

""" Family """
family_name = input('Insert family name: ')

""" Dictionaries """
father_details = {"name": father_name, "age": father_age}
mother_details = {"name": mother_name, "age": mother_age}
parents = {"father": father_details, "mother": mother_details}


""" Running example """
family = Family(parents, children, family_name)
print(f'\n\n\n\n--- {family_name} family ---\n')
print(f'Parents details:\n father: {family.parents["father"]}\n mother: {family.parents["mother"]}')
print('\nChildren details: ')
for k, v in family.children.items():
    print(f'name: {k},   age: {v} \n')
print('\n--- * ---')



