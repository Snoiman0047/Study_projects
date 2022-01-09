
class Father(object):

    father_name = ''
    father_age = None

    def __init__(self, f_name='', f_age=None):
        self.father_name = f_name
        self.father_age = f_age

    def set_father_name(self, f_name):
        self.father_name = f_name

    def get_father_name(self):
        return self.father_name

    def set_father_age(self, f_age):
        self.father_age = f_age

    def get_father_age(self):
        return self.father_age
pass


class Mother(object):

    mother_name = ''
    mother_age = None

    def __init__(self, m_name='', m_age=None):
        self.mother_name = m_name
        self.mother_age = m_age

    def set_mother_name(self, m_name):
        self.mother_name = m_name

    def get_mother_name(self):
        return self.mother_name

    def set_mother_age(self, m_age):
        self.mother_age = m_age

    def get_mother_age(self):
        return self.mother_age
pass


class Child(Father, Mother):

    child_name = ''
    child_age = None
    father = Father()
    mother = Mother()

    def __init__(self, c_name='', c_age=None, father=Father, mother=Mother):
        self.child_name = c_name
        self.mother_age = c_age
        self.father = father
        self.mother = mother

    def set_child_name(self, c_name):
        self.child_name = c_name

    def get_child_name(self):
        return self.child_name

    def set_child_age(self, c_age):
        self.mother_age = c_age

    def get_child_age(self):
        return self.mother_age

    def set_father(self, f_name, f_age):
        self.father.father_name = f_name
        self.father.father_age = f_age

    def set_mother(self, m_name, m_age):
        self.mother.mother_name = m_name
        self.mother.mother_age = m_age

    def set_parents(self, father_details, mother_details):
        self.father.set_father_name(father_details['name'])
        self.father.set_father_age(father_details['age'])
        self.mother.set_mother_name(father_details['name'])
        self.mother.set_mother_age(father_details['age'])

        self.mother = mother_details
pass


class Family(Child):

    parents = {}
    children = {}
    last_name = ''

    def __init__(self, parents, children, l_name):
        self.parents = parents
        for n, a in children.items():
            self.children[n] = a
        self.last_name = l_name

    def add_child(self, c_name, c_age):
        child = Child(c_name, c_age)
        self.children[child.get_child_name()] = child.get_child_age()

    def get_children(self):
        return self.children

    def get_child(self, index):
        return self.children[index+1]

    def get_parents_name(self):
        return self.parents['name']
pass

